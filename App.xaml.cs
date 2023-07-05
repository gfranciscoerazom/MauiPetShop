using MauiPetShop.Services;

namespace MauiPetShop;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new NavigationPage(new ContactosPage());
        MainPage = new NavigationPage(new LoginPage());
        //MainPage = new NavigationPage(new CameraPage());
    }
}
