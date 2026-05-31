using System;
using System.Globalization;

namespace calculatorbmi
{
    public partial class MainPage : ContentPage
    {
        string _obliczanie;
        public string Obliczanie
        {
            get => _obliczanie;
            set { _obliczanie = value; OnPropertyChanged(nameof(Obliczanie)); }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        // handler dla Clicked="obliczanie" w XAML
        void obliczanie(object sender, EventArgs e)
        {
            // zabezpieczenia przed null/nieprawidłowymi danymi
            var wText = waga?.Text;
            var hText = wzrost?.Text;

            // akceptuj zarówno przecinek jak i kropkę jako separator dziesiętny
            if (string.IsNullOrWhiteSpace(wText) || string.IsNullOrWhiteSpace(hText))
            {
                Obliczanie = "Podaj wagę i wzrost";
                return;
            }

            wText = wText.Replace(',', '.');
            hText = hText.Replace(',', '.');

            if (!double.TryParse(wText, NumberStyles.Float, CultureInfo.InvariantCulture, out var weight) ||
                !double.TryParse(hText, NumberStyles.Float, CultureInfo.InvariantCulture, out var height))
            {
                Obliczanie = "Nieprawidłowe dane";
                return;
            }

            // jeśli użytkownik podał wzrost w cm (np. > 3), zamień na metry
            if (height > 3) height /= 100.0;
            if (height <= 0)
            {
                Obliczanie = "Nieprawidłowy wzrost";
                return;
            }

            var bmi = weight / (height * height);
            Obliczanie = $"BMI: {bmi:F2}";
        }
    }
}
