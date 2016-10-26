using System.ComponentModel.Design;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	partial class frmMain : Form
	{

		private IServerProvider serverprovider;
		private ServerQuery infoGrabber;

		public frmMain( IServerProvider serverprovider )
		{
			this.serverprovider = serverprovider;
			infoGrabber = new ServerQuery();
			InitializeComponent();
			Task.Factory.StartNew( LoadNext );
		}

		public void LoadNext()
		{
		}

	}
}
