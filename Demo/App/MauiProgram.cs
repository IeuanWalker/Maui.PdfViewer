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
			.UseStateButton();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}