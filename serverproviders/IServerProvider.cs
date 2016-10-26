using System.Net;

namespace yugecin.sampbrowser
{
	interface IServerProvider
	{

		ServerInfo GetNext();

	}
}
