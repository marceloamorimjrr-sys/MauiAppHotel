private async void OnSobreButtonClicked(object sender, EventArgs e)
{
    // Navega para a rota registrada no AppShell.xaml.cs
    await Shell.Current.GoToAsync(nameof(SobrePage));
}
