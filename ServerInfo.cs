using System.Net;

namespace yugecin.sampbrowser
{
	struct ServerInfo
	{
		public bool online;
		public bool password;
		public IPEndPoint address;
		public string ip;
		public int port;
		public string hostname;
		public int players;
		public int maxplayers;
		public int ping;
		public string mode;
		public string language;
	}
}
