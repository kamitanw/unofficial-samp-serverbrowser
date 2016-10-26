using System.Net;

namespace yugecin.sampbrowser
{
	interface IServerProvider
	{

		IPEndPoint GetNext();

	}
}
