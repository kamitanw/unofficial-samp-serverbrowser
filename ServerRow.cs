using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	struct ServerRow
	{

		public ServerInfo info;
		public ListViewItem listItem;

		public ServerRow( ServerInfo info, ListViewItem listItem )
		{
			this.info = info;
			this.listItem = listItem;
		}

	}
}
