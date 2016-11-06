using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	public class CustomListView : ListView
	{

		[DllImport("user32.dll")]
		private static extern long GetWindowLong( IntPtr hWnd, int nIndex );

		[DllImport("user32.dll")]
		private static extern long SetWindowLong( IntPtr hWnd, int nIndex, long dwNewLong );

		private const int GWL_STYLE = -16;

		private const long WS_HSCROLL = 0x00100000L;
		private const long WS_VSCROLL = 0x00200000L;

		private const int WM_STYLECHANGING = 0x7C;
		private const int WM_STYLECHANGED = 0x7D;
		private const int WM_MOUSEWHEEL = 0x20A;
		private const int WM_MOUSEHWHEEL = 0x20E;

		protected override void WndProc( ref Message msg )
		{
			if( msg.Msg == WM_STYLECHANGED || msg.Msg == WM_STYLECHANGING )
			{
				base.WndProc( ref msg );
				return;
			}
			long windowLong = GetWindowLong( this.Handle, GWL_STYLE ); 
			if( ( windowLong & WS_HSCROLL ) > 0 )
			{
				windowLong &= ~WS_HSCROLL;
				SetWindowLong( this.Handle, GWL_STYLE, windowLong );
			}
			if( msg.Msg == WM_MOUSEHWHEEL )
			{
				return;
			}
			if( msg.Msg == WM_MOUSEWHEEL )
			{
				if( ( windowLong & WS_VSCROLL ) == 0 )
				{
					return;
				}
			}
			base.WndProc( ref msg );
		}

	}
}
