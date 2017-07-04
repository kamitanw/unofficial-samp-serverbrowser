#include "ulauncher.h"
#using <mscorlib.dll>
#using <System.dll>
#using <System.Windows.Forms.dll>
using namespace System;

ref class MLauncher
{
public:

	void Launch()
	{
		launch();
	}

	System::String ^GetName() {
		char buffer[24];
		getname(buffer, sizeof(buffer));
		return gcnew System::String(buffer);
	}

};