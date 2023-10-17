namespace _07_Pages.Views;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new PaginaTabbed();
    }
}