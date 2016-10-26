using System.Net;

namespace yugecin.sampbrowser
{
	class TestServerProvider : IServerProvider
	{

		public IPEndPoint GetNext() {
			return new IPEndPoint( new IPAddress( new byte[] { 127, 0, 0, 1 } ), 7777 );
		}

	}
}
