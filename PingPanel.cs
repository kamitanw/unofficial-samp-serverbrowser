using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yugecin.sampbrowser {

	public partial class PingPanel : UserControl {

		public PingPanel() {
			InitializeComponent();

			MkPingText();
		}

		private void MkPingText() {
			StringFormat format = new StringFormat();
			format.Alignment = StringAlignment.Center;
			format.LineAlignment = StringAlignment.Center;
			format.Trimming = StringTrimming.EllipsisCharacter;

			Bitmap img = new Bitmap(pnlPingText.Height, pnlPingText.Width);
			Graphics G = Graphics.FromImage(img);
			G.Clear(this.BackColor);

			SolidBrush brush_text = new SolidBrush(this.ForeColor);
			G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
			G.DrawString("Ping", this.Font, brush_text, new Rectangle(0, 0, img.Width, img.Height), format);
			brush_text.Dispose();

			img.RotateFlip(RotateFlipType.Rotate270FlipNone);

			pnlPingText.BackgroundImage = img;
		}

	}

}
