using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	public class CustomListView : ListView
	{

		[DllImport("user32.dll")]
		private static extern int GetWindowLong( IntPtr hWnd, int nIndex );

		//[DllImport("user32.dll")]
		//private static extern long ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

		protected override void WndProc( ref Message msg )
		{
			//ShowScrollBar( this.Handle, 0, 0 ); // hide it by enlarging the height instead (see FrmMain.cs constructor)
			if( msg.Msg == 0x20E ) // WM_MOUSEHWHEEL
			{
				return;
			}
			if( msg.Msg == 0x20A ) // WM_MOUSEWHEEL 
			{
				if( ( GetWindowLong( this.Handle, -16 ) & 0x200000 ) == 0 ) // doesn't have vscrollbar
				{
					return;
				}
			}
			base.WndProc( ref msg );
		}

	}
}
