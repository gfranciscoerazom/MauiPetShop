using MauiPetShop.Services;

namespace MauiPetShop;

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

		builder.Services.AddSingleton<IContactoRepository, ContactoService>(); 

		builder.Services.AddSingleton<MainPage>();
		//builder.Services.AddSingleton<NuevoContactoPage>();
		//builder.Services.AddSingleton<DetailsPage>();

		return builder.Build();
	}
}
