using System.Net;

namespace yugecin.sampbrowser
{
	class TestServerProvider : IServerProvider
	{

		private bool provided;

		public ServerInfo GetNext() {
			ServerInfo info = new ServerInfo();
			if( provided )
			{
				return info;
			}
			provided = true;
			info.ip = "127.0.0.1";
			info.port = 7775;
			return info;
		}

	}
}
