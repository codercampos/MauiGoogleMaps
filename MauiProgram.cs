using Maui.GoogleMaps.Hosting;
using Microsoft.Extensions.Logging;

namespace MauiGoogleMaps;

public static class MauiProgram
{
    public const string GoogleApiKey = "{YOUR KEY HERE}";
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

#if ANDROID
        builder.UseGoogleMaps();
#elif IOS
        builder.UseGoogleMaps(GoogleApiKey);
#endif

		return builder.Build();
	}
}
