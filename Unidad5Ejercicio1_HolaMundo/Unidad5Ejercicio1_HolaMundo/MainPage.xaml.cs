namespace Unidad5Ejercicio1_HolaMundo
{
    public partial class MainPage : ContentPage
    {

        String nombre;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            await DisplayAlert("Saludo: ", $"Hola {nombre}", ":D");
            String apellido = await DisplayPromptAsync($"Hola {nombre}", "Escribe tu apellido");
            await DisplayAlert("Saludo: ", $"Hola {nombre}, {apellido}", "Enhorabuena");

        }
    }
}