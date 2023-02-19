using Microsoft.Extensions.Logging;
using CheckedBook.View;

namespace CheckedBook;

public static class MauiProgram
{
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
		builder.Services.AddSingleton<AccountsViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<AccountsPage>();

		return builder.Build();
	}
}

