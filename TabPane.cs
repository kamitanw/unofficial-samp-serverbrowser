using System;
using System.Windows.Forms;
using System.Drawing;

namespace yugecin.sampbrowser {

	public class TabPane : Panel {

		private static Pen whitepen = new Pen( Color.White );
		private static Pen blackpen = new Pen( Color.Black );
		private static Pen darkpen = new Pen( new SolidBrush( Color.FromKnownColor( KnownColor.ControlDark ) ) );
		private static Pen lightpen = new Pen( new SolidBrush( Color.FromKnownColor( KnownColor.Control ) ) );
		private static Brush darkbrush = new SolidBrush( Color.FromKnownColor( KnownColor.ControlDark ) );
		private static Brush lightbrush = new SolidBrush( Color.FromKnownColor( KnownColor.Control ) );

		private static Font tabfont = new Font( "Arial", 9f, FontStyle.Bold );

		private struct Tab {
			public int width;
			public string text;
		}

		private Tab[] tabs = new Tab[10];
		private int ntabs;
		private int activetab = 0;
		private int totalwidth = 3;

		public class TabEventArgs {
			public int OldIndex { get; set; }
			public int NewIndex { get; set; }
		}

		public delegate TabEventArgs TabChangedHandler(object sender, TabEventArgs e);
		public event TabChangedHandler SelectedTabChanged;

		protected override void OnPaint( PaintEventArgs e )
		{
			e.Graphics.FillRectangle( lightbrush, 0, 0, Width, Height );
			e.Graphics.DrawLine( darkpen, 0, 0, Width - 1, 0 );
			for( int i = ntabs - 1; i >= 0; i-- ) {
				if( tabs[i].width > 0 ) {
					break;
				}
				tabs[i].width = (int) e.Graphics.MeasureString( tabs[i].text, tabfont ).Width + 30;
				totalwidth += tabs[i].width - 4;
			}
			int x = totalwidth;
			int activetabx = -1;
			for( int i = ntabs - 1; i >= 0; i-- ) {
				if( i == activetab ) {
					activetabx = x;
					goto skip;
				}	
				DrawTab( e.Graphics, tabs[i], x, darkbrush, false );
skip:
				x -= tabs[i].width - 4;
			}
			if( activetabx != -1 ) {
				DrawTab( e.Graphics, tabs[activetab], activetabx, lightbrush, true );
			}
		}

		private void DrawTab( Graphics g, Tab tab, int x, Brush bgbrush, bool isactive ) {
			x -= tab.width - 4;
			g.FillPolygon( bgbrush, new Point[] {
				new Point( x, 0 ),
				new Point( x + tab.width, 0 ),
				new Point( x + tab.width - 5, 18 ),
				new Point( x + 5, 18 )
			} );
			if( isactive ) {
				g.DrawLine( whitepen, x + 1, 1, x + 6, 18 );
				g.DrawLine( darkpen, x + 5, 17, x + tab.width - 6, 17 );
				g.DrawLine( darkpen, x + tab.width - 6, 18, x + tab.width - 1, 1 );
				g.DrawLine( darkpen, x - 1, 0, x, 0 );
				g.DrawLine( darkpen, x + tab.width - 1, 0, x + tab.width, 0 );
			} else {
				g.DrawLine( lightpen, x, 1, x + tab.width, 1 );
			}
			g.DrawLine( blackpen, x, 1, x + 5, 18 );
			g.DrawLine( blackpen, x + 5, 18, x + tab.width - 5, 18 );
			g.DrawLine( blackpen, x + tab.width - 5, 18, x + tab.width, 1 );
			g.DrawString( tab.text, tabfont, Brushes.Black, x + 17, 2 );
		}

		public void AddTab( string text ) {
			if( ntabs == tabs.Length ) {
				MessageBox.Show( "Too many tabs", "", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}
			tabs[ntabs++].text = text;
		}

		protected override void OnMouseUp(MouseEventArgs e) {
			base.OnMouseUp(e);
			if( e.X < 3 || e.X > totalwidth + 5 ) {
				return;
			}
			int x = e.X;
			for( int i = 0; i < ntabs; i++ ) {
				if( x > tabs[i].width ) {
					x -= tabs[i].width - 5;
					if( i == ntabs - 1 && x < 10 ) {
						goto lasttab;
					}
					continue;
				}
lasttab:
				if( activetab != i ) {
					if( SelectedTabChanged != null ) {
						SelectedTabChanged( this, new TabEventArgs() { OldIndex = activetab, NewIndex = i } );
					}
					activetab = i;
					this.Invalidate( new Rectangle( 0, 0, totalwidth + 3, 18 ), false );
				}
				return;
			}
		}

	}

}
