using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace yugecin.sampbrowser
{
	partial class FrmMain : Form
	{

		private IServerProvider serverprovider;
		private ServerQuery query;
		private Thread loadServersThread;
		private List<ServerRow> serverList;
		private Dictionary<ServerInfo, ServerRow> serverMap;

		private ImageList icons;

		private Pen blackpen;

		private int visibleServerCount;
		private int visiblePlayerCount;
		private int visibleFreeSlotCount;

		public FrmMain( IServerProvider serverprovider )
		{
			this.serverprovider = serverprovider;
			query = new ServerQuery();
			serverList = new List<ServerRow>();
			serverMap = new Dictionary<ServerInfo, ServerRow>();
			icons = new ImageList();
			icons.Images.Add( "pwTrue", Icons._lock );
			icons.Images.Add( "pwFalse", Icons.lock_open );
			blackpen = new Pen( new SolidBrush( Color.Black ) );
			InitializeComponent();
			lstServers.Height += SystemInformation.HorizontalScrollBarHeight;
			lstServers.Columns[5].Width = SystemInformation.VirtualScreen.Width;
			lstServers.SmallImageList = icons;
			loadServersThread = new Thread( LoadServers );
			loadServersThread.Start();
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

				ListViewItem listItem = new ListViewItem( new string[6] );
				ServerRow row = new ServerRow( info, listItem );
				listItem.Tag = row;
				serverList.Add( row );
				serverMap.Add( info, row );
				UpdateServerRow( info );

				lstServers.Items.Add( listItem );
				if( lstServers.Items.Count % 2 == 1 )
				{
					listItem.BackColor = System.Drawing.Color.FromArgb( 239, 239, 239 );
				}

				query.LoadInitial( info );
				if( info.online )
				{
					UpdateServerRow( info );
				}
			}
		}

		private delegate void updateServerRow( ServerInfo info );
		private void UpdateServerRow( ServerInfo info )
		{
			if( this.InvokeRequired )
			{
				this.BeginInvoke( new updateServerRow( UpdateServerRow ), info );
				return;
			}
			ListViewItem listItem = serverMap[info].listItem;
			visiblePlayerCount -= info.previousPlayers;
			visibleFreeSlotCount -= info.previousFreeSlots;
			visibleServerCount -= info.wasOnline ? 1 : 0;
			if( info.online )
			{
				listItem.ImageKey = "pw" + info.password;
				listItem.SubItems[1].Text = info.hostname;
				listItem.SubItems[2].Text = info.players + " / " + info.maxplayers;
				listItem.SubItems[3].Text = info.ping.ToString();
				listItem.SubItems[4].Text = info.mode;
				listItem.SubItems[5].Text = info.language;
				visibleServerCount += 1;
				visiblePlayerCount += info.players;
				visibleFreeSlotCount += info.maxplayers - info.players;
			}
			else
			{
				//listItem.ImageKey = "pw" + true;
				listItem.SubItems[1].Text = "(Retrieving info...) " + info.ip + ":" + info.port;
				listItem.SubItems[2].Text = "0 / 0";
				listItem.SubItems[3].Text = "-";
				listItem.SubItems[4].Text = "";
				listItem.SubItems[5].Text = "";
			}
			info.wasOnline = info.online;
			info.previousPlayers = info.players;
			info.previousFreeSlots = info.maxplayers - info.players;
			lblStatus.Text = string.Format( "{0} players on {1} servers ({2} player slots available)", visiblePlayerCount, visibleServerCount, visibleFreeSlotCount );
		}

		private void frmMain_FormClosed( object sender, FormClosedEventArgs e )
		{
			if( loadServersThread.IsAlive )
			{
				loadServersThread.Abort();
				loadServersThread.Join();
				// TODO: kill the socket or sth
			}
		}

		private void pnlContent_Paint( object sender, PaintEventArgs e )
		{
			e.Graphics.DrawLine( blackpen, new Point( 0, 0 ), new Point( pnlControls.Width - 1, 0 ) );
		}

	}
}
