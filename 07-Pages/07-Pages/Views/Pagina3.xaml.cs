namespace _07_Pages.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}
    private async void btn3Clicker(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}