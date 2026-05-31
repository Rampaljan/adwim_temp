namespace poczta
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SprawdzCene_Clicked(object sender, EventArgs e)
        {
            if (ListRadio.IsChecked)
            {
                ObrazekPrzesylki.Source = "list.png";
                CenaLabel.Text = "Cena: 1,5zł";
            }
            else if (PaczkaRadio.IsChecked)
            {
                ObrazekPrzesylki.Source = "paczka.png";
                CenaLabel.Text = "Cena: 10zł";
            }
            else // Pocztowka (default)
            {
                ObrazekPrzesylki.Source = "pocztowka.png";
                CenaLabel.Text = "Cena: 1zł";
            }
        }

        private async void Zatwierdz_Clicked(object sender, EventArgs e)
        {
            string kodPocztowy = KodPocztowyEntry.Text ?? string.Empty;

            if (kodPocztowy.Length != 5)
            {
                await DisplayAlert("Kod pocztowy", "Nieprawidłowa liczba cyfr w kodzie pocztowym", "OK");
            }
            else if (!int.TryParse(kodPocztowy, out _))
            {
                await DisplayAlert("Kod pocztowy", "Kod pocztowy powinien się składać z samych cyfr", "OK");
            }
            else
            {
                await DisplayAlert("Kod pocztowy", "Dane przesyłki zostały wprowadzone", "OK");
            }
        }
    }
}
