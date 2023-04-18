using IeuanWalker.Maui.StateButton;
using Microsoft.Extensions.Logging;

namespace App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseStateButton()
			.Services.AddHybridWebView();

		Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
		{
#if ANDROID
			Android.Webkit.WebView webView = handler.PlatformView;
			webView.Settings.JavaScriptEnabled = true;
			webView.Settings.AllowFileAccess = true;
			webView.Settings.AllowUniversalAccessFromFileURLs = true;
#endif
		});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}