using System.Net;

namespace yugecin.sampbrowser
{
	class TestServerProvider : IServerProvider
	{

		public ServerInfo GetNext() {
			ServerInfo info = new ServerInfo();
			info.ip = "127.0.0.1";
			info.port = 7777;
			return info;
		}

	}
}
