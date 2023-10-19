namespace _07_Pages.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void btnClicker(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new PaginaTabbed());
    }
}