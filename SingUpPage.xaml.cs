using MauiPetShop.Models;
using MauiPetShop.Services;

namespace MauiPetShop;

public partial class SingUpPage : ContentPage
{
    private readonly IContactoRepository dataService;

    public SingUpPage()
	{
		InitializeComponent();
        dataService = new ContactoService();
    }

    private async void SingUpButton_Clicked(object sender, EventArgs e)
    {
		var newCliente = new Cliente
		{
			Nombre = NameEntry.Text,
			Email = EmailEntry.Text,
			Numero = PhoneNumberEntry.Text,
			Contrasena = (PasswordEntry.Text == ConfirmPasswordEntry.Text) ? PasswordEntry.Text : throw new Exception("Las contraseñas no coinciden")
		};

		if (await dataService.AddClienteAsync(newCliente))
		{
            await DisplayAlert("Éxito", "Cliente agregado correctamente", "OK");
        }
        else
		{
            await DisplayAlert("Error", "No se pudo agregar el cliente", "OK");
        }

		await Navigation.PopAsync();
    }
}