using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace yugecin.sampbrowser
{
	class ServerQuery
	{

		private Stopwatch pingTimer;

		public ServerQuery()
		{
			pingTimer = new Stopwatch();
		}

		public void LoadInitial( ServerInfo info )
		{
			IPAddress ipaddress;
			if( !IPAddress.TryParse( info.ip, out ipaddress ) )
			{
				return;
			}
			info.ipbytes = ipaddress.GetAddressBytes();
			info.address = new IPEndPoint( ipaddress, info.port );
			GetDefaultInfo( info );
		}

		private void GetDefaultInfo( ServerInfo info )
		{
			byte[] response;
			IPEndPoint IPEP = new IPEndPoint( info.address.Address, info.port );
			UdpClient c = new UdpClient();
			c.Client.SendTimeout = 3000;
			c.Client.ReceiveTimeout = 3000;
			c.Connect( IPEP );
			pingTimer.Start();
			try
			{
				c.Send( new byte[] {
					(byte) 'S', (byte) 'A', (byte) 'M', (byte) 'P',
					info.ipbytes[0], info.ipbytes[1], info.ipbytes[2], info.ipbytes[3],
					(byte) ( info.port & 0xFF ), (byte) ( ( info.port >> 8 ) & 0xFF ),
					0x69
				}, 11 );
				response = c.Receive( ref IPEP );
				c.Close();
			}
			catch( Exception )
			{
				return;
			}
			info.ping = (int) pingTimer.ElapsedMilliseconds;
			pingTimer.Reset();
			if( response.Length < 28 )
			{
				return;
			}
			info.online = (
				response[0] == (byte) 'S' &&
				response[1] == (byte) 'A' &&
				response[2] == (byte) 'M' &&
				response[3] == (byte) 'P'
			);
			if( !info.online )
			{
				return;
			}
			info.password = response[11] == 0x1;
			info.players = response[12] | response[13] << 8;
			info.maxplayers = response[14] | response[15] << 8;
			int position = 16;
			position = ReadString( response, position, 4, out info.hostname );
			position = ReadString( response, position, 4, out info.mode );
			position = ReadString( response, position, 4, out info.language );
		}

		private int ReadString( byte[] data, int position, int lengthsize, out string result )
		{
			int len = 0;
			for( int i = 0; i < lengthsize; i++ )
			{
				len |= data[position++] << ( i * 8 );
			}
			if( len == 0 )
			{
				result = "-";
				return position;
			}
			byte[] str = new byte[len];
			for( int i = 0; i < len; i++ )
			{
				str[i] = data[position++];
			}
			result = Encoding.GetEncoding( 1252 ).GetString( str );
			return position;
		}

	}
}
