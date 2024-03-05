using UraniumUI;
using MauiIcons.Material;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace Diplom;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMaterialMauiIcons()
            .UseSkiaSharp(true)
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddMaterialIconFonts();
            });

        //builder.Services.AddSingleton<MainPage>();

        builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDetailPage>();

		builder.Services.AddSingleton<ListDetailPage>();

		builder.Services.AddSingleton(AudioManager.Current);

		return builder.Build();
	}
}
