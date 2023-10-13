namespace Ejercicio4Inicial
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
   
        private void DatePickerEntrada_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            // Cuando se selecciona una fecha de entrada, habilitar el DatePicker de salida
            datePickerSalida.IsEnabled = true;
        }
    }
}