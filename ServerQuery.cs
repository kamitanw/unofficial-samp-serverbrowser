using System.Net;
using System.Net.Sockets;

namespace yugecin.sampbrowser
{
	class ServerQuery
	{

		public ServerInfo GetDefaultInfo( ServerInfo info )
		{
			IPAddress ipaddress;
			if( !IPAddress.TryParse( info.ip, out ipaddress ) )
			{
				return info;
			}
			UdpClient c = openConnection( ipaddress, info );
			if( info.online )
			{

			}
			c.Close();
			return info;
		}

		public UdpClient openConnection( IPAddress ipaddress, ServerInfo info )
		{
			byte[] ipbytes = ipaddress.GetAddressBytes();
			IPEndPoint IPEP = new IPEndPoint( ipaddress, info.port );
			UdpClient c = new UdpClient();
			c.Client.SendTimeout = 3000;
			c.Client.ReceiveTimeout = 3000;
			c.Connect( IPEP );
			c.Send( new byte[] {
				(byte) 'S', (byte) 'A', (byte) 'M', (byte) 'P',
				ipbytes[0], ipbytes[1], ipbytes[2], ipbytes[3],
				(byte) ( info.port & 0xFF ), (byte) ( ( info.port >> 8 ) & 0xFF ),
				0x70, 0x34, 0x31, 0x35, 0x0
			}, 15 );
			System.Console.WriteLine( "sent");
			byte[] response = c.Receive( ref IPEP );
			System.Console.WriteLine( "hiiii" );
			System.Console.WriteLine( response.Length );
			if( response.Length >= 15 )
			{
				info.online = (
					response[10] == (byte) 'p' &&
					response[11] == (byte) '4' &&
					response[12] == (byte) '1' &&
					response[13] == (byte) '5' &&
					response[14] == (byte) '0'
				);
			}
			return c;
		}

	}
}
