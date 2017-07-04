﻿using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	class Loader
	{

		static void Main()
		{
			Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
#if DEBUGBUILD
			Application.Run( new FrmMain( new TestServerProvider() ) );
#else
			Application.Run( new FrmMain( new GamestateServerProvider() ) );
#endif
		}

	}
}
