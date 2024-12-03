namespace ExamenT2DMR_bueno.Vistas;

public partial class Ejercicio1 : ContentPage
{
	public Ejercicio1()
	{
		InitializeComponent();
	}

    private async void onRegistroClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Ejercicio2());
    }

    private async void onProductosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Ejercicio3());
    }
}