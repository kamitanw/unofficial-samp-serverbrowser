#include "ulauncher.h"
#using <mscorlib.dll>
using namespace System;

ref class MLauncher
{
public:
	MLauncher()
	{
		ulauncher = new ULauncher();
		if (!ulauncher) {
			throw gcnew OutOfMemoryException();
		}
	}

	~MLauncher()
	{
		Destruct();
	}

	!MLauncher()
	{
		Destruct();
	}

	void Launch()
	{
		if (ulauncher) {
			ulauncher->Launch();
		}
	}

private:
	ULauncher *ulauncher;

	void Destruct()
	{
		if (ulauncher) {
			delete ulauncher;
		}
	}

};