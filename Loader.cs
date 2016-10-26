using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	class Loader
	{

		static void Main()
		{
			Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
			Application.Run( new frmMain( new TestServerProvider() ) );
		}

	}
}
