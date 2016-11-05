using System.Net;

namespace yugecin.sampbrowser
{
	class ServerInfo
	{

		public bool online;
		public bool password;
		public byte[] ipbytes;
		public IPEndPoint address;
		public string ip;
		public int port;
		public string hostname;
		public int players;
		public int maxplayers;
		public int ping;
		public string mode;
		public string language;
		public bool wasOnline;
		public int previousPlayers;
		public int previousFreeSlots;

	}
}
