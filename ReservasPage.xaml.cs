namespace MauiAppHotel.Views;

public partial class ReservasPage : ContentPage
{
	public ReservasPage()
	{
		InitializeComponent();
	}

    private async void OnConfirmarReservaClicked(object sender, EventArgs e)
    {
        // Exibe um alerta simples para simular a confirmação da reserva
        await DisplayAlert("Sucesso!", "Sua solicitação de reserva foi enviada.", "OK");
    }
}
