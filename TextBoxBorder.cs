using System;
using System.Drawing;
using System.Windows.Forms;

namespace yugecin.sampbrowser {

	public class TextBoxBorder : Panel {

		private static Pen pen = new Pen( new SolidBrush( Color.FromArgb( 255, 128, 128, 128 ) ) );

		protected override void OnPaint( PaintEventArgs e )
		{
			base.OnPaint( e );
			e.Graphics.DrawLine( pen, new Point( 0, 0 ), new Point( 0, Height - 1 ) );
			e.Graphics.DrawLine( pen, new Point( 0, 0 ), new Point( Width - 1, 0 ) );
			e.Graphics.DrawLine( pen, new Point( Width - 1, 0 ), new Point( Width - 1, Height - 1 ) );
			e.Graphics.DrawLine( pen, new Point( 0, Height - 1 ), new Point( Width - 1, Height - 1 ) );
		}

	}

}
