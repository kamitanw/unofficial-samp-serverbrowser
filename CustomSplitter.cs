using System.Drawing;
using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	public class CustomSplitter : Splitter
	{

		private static Pen darkPen = new Pen( new SolidBrush( Color.FromKnownColor( KnownColor.ControlDark ) ) );
		private static Pen lightPen = new Pen( new SolidBrush( Color.FromKnownColor( KnownColor.ControlLightLight ) ) );

		protected override void OnPaint( PaintEventArgs e )
		{
			base.OnPaint( e );
			if( ( Dock & ( DockStyle.Left | DockStyle.Right ) ) > 0 )
			{
				e.Graphics.DrawLine( darkPen, new Point( 0, 0 ), new Point( 0, Height - 1 ) );
				e.Graphics.DrawLine( lightPen, new Point( 2, 0 ), new Point( 2, Height - 1 ) );
				e.Graphics.DrawLine( darkPen, new Point( Width - 3, 0 ), new Point( Width - 3, Height - 1 ) );
				e.Graphics.DrawLine( lightPen, new Point( Width - 1, 0 ), new Point( Width - 1, Height - 1 ) );
			}
			else
			{
				e.Graphics.DrawLine( darkPen, new Point( 0, 0 ), new Point( 0, 0 ) );
				e.Graphics.DrawLine( lightPen, new Point( 0, 2 ), new Point( Width - 1, 2 ) );
				e.Graphics.DrawLine( darkPen, new Point( 0, Height - 3 ), new Point( Width - 1, Height - 3 ) );
				e.Graphics.DrawLine( lightPen, new Point( 0, Height - 1 ), new Point( Width - 1, Height - 1 ) );
			}
		}

	}
}
