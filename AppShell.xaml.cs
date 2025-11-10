using MauiAppHotel.Views; 

namespace MauiAppHotel;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        
        // Registro da Rota "Sobre"
        Routing.RegisterRoute(nameof(SobrePage), typeof(SobrePage));
        
        // Registro da NOVA Rota "Reservas"
        Routing.RegisterRoute(nameof(ReservasPage), typeof(ReservasPage));
	}
}
