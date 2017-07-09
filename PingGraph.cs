using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace yugecin.sampbrowser {

	public class PingGraph : Panel {

		private static Pen pen = new Pen( new SolidBrush( Color.FromArgb( 255, 111, 111, 111 ) ) );
		private static Pen dashpen = new Pen( new SolidBrush( Color.FromArgb( 255, 111, 111, 111 ) ) );
		private static Brush bgbrush = new SolidBrush( Color.FromKnownColor( KnownColor.Control ) );

		static PingGraph() {
			dashpen.DashStyle = DashStyle.Dot;
			dashpen.DashOffset = 0;
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			e.Graphics.FillRectangle( bgbrush, 0 , 0, 12, Height );
			e.Graphics.FillRectangle( Brushes.Black, 13, 0, Width , Height );
			for (int i = 5; i < 68; i += 6) {
				e.Graphics.DrawLine( pen, new Point( 0, i ), new Point( 5, i ) );
				i += 6;
				e.Graphics.DrawLine( dashpen, new Point( 13, i ), new Point( Width - 1, i ) );
				e.Graphics.DrawLine( dashpen, new Point( 3, i ), new Point( 6, i ) );
			}
		}

	}

}
