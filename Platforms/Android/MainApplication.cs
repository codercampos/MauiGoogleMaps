using Android.App;
using Android.Runtime;

namespace MauiGoogleMaps;

[Application]
[MetaData("com.google.android.maps.v2.API_KEY",
    Value = MauiProgram.GoogleApiKey)]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
