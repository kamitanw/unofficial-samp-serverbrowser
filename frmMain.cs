using System.Threading;
using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	partial class frmMain : Form
	{

		private IServerProvider serverprovider;
		private ServerQuery query;

		public frmMain( IServerProvider serverprovider )
		{
			this.serverprovider = serverprovider;
			query = new ServerQuery();
			InitializeComponent();
			Thread t = new Thread( LoadServers );
			t.Start();
		}

		private void LoadServers()
		{
			for( ; ; )
			{
				ServerInfo info = serverprovider.GetNext();
				if( info.ip == null )
				{
					return;
				}
				query.LoadInitial( info );
				if( info.online )
				{
					addServer( info );
				}
			}
		}

		private delegate void _addServer( ServerInfo info );
		private void addServer( ServerInfo info )
		{
			if( this.InvokeRequired )
			{
				this.BeginInvoke( new _addServer( addServer ), new object[] { info } );
				return;
			}
			lstServers.Items.Add( new ListViewItem( info.GetListItemText() ) );
			System.Console.WriteLine(info.ping);
		}

	}
}
