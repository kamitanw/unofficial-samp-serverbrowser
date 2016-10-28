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
			int servers = 0;
			int players = 0;
			int freeslots = 0;
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
					servers++;
					players += info.players;
					freeslots += info.maxplayers - info.players;
					AddServer( info );
					UpdateInfo( servers, players, freeslots );
				}
			}
		}

		private delegate void addServer( ServerInfo info );
		private void AddServer( ServerInfo info )
		{
			if( this.InvokeRequired )
			{
				this.BeginInvoke( new addServer( AddServer ), new object[] { info } );
				return;
			}
			lstServers.Items.Add( new ListViewItem( info.GetListItemText() ) );
		}

		private delegate void updateInfo( int servers, int players, int freeslots );
		private void UpdateInfo( int servers, int players, int freeslots )
		{
			if( this.InvokeRequired )
			{
				this.BeginInvoke( new updateInfo( UpdateInfo ), new object[] { servers, players, freeslots } );
				return;
			}
			lblStatus.Text = string.Format( "{0} players on {1} servers ({2} player slots available)", players, servers, freeslots );
		}

	}
}
