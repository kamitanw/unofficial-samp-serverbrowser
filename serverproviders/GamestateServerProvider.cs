using System.IO;
using System.Net;
using System.Text;

namespace yugecin.sampbrowser
{
	class GamestateServerProvider : IServerProvider
	{

		private const string url = "http://www.game-state.com/index.php?spp=50&game=samp&page=";
		private int page = 1;
		private bool end;
		private ServerInfo[] pool;
		private byte poolsize;
		private byte index;

		public GamestateServerProvider()
		{
			pool = new ServerInfo[50];
		}

		public ServerInfo GetNext()
		{
			if( end )
			{
				return null;
			}
			if( index >= poolsize )
			{
				LoadNewList();
				return GetNext();
			}
			return pool[index++];
		}

		private void LoadNewList()
		{
			index = 0;
			poolsize = 0;
			HttpWebRequest req = (HttpWebRequest) WebRequest.Create( url + page++ );
			req.Method = "GET";
			HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
			StreamReader reader = new StreamReader( resp.GetResponseStream() );
			StringBuilder table = new StringBuilder();
			string line;
			while( null != ( line = reader.ReadLine() ) )
			{
				int idx = line.IndexOf( "samp://" );
				if( idx == -1 )
				{
					continue;
				}
				idx += 7;
				int idx2 = line.IndexOf( '"', idx );
				if( idx2 == -1 )
				{
					continue;
				}
				string[] ipport = line.Substring( idx, idx2 - idx ).Split( ':' );
				ServerInfo info = new ServerInfo();
				info.ip = ipport[0];
				info.port = int.Parse( ipport[1] );
				pool[poolsize++] = info;
			}
			if( poolsize == 0 )
			{
				end = true;
			}
		}

	}
}
