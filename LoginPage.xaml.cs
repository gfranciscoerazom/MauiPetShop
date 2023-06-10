using MauiPetShop.Services;

namespace MauiPetShop;

public partial class LoginPage : ContentPage
{
    private readonly IContactoRepository dataService;

    public LoginPage()
	{
		InitializeComponent();

        dataService = new ContactoService();
    }

    public async void OnClickLogin(object sender, EventArgs e)
    {
        var clientesList = await dataService.GetClientesAsync();

        foreach (var cliente in clientesList)
        {
            if (cliente.Nombre.Equals(Nombre.Text) && cliente.Contrasena.Equals(Contrasena.Text))
            {
                await Navigation.PushAsync(new ContactosPage());
            }
        }
    }
}
