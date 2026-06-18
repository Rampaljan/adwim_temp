using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvvm_template.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        //on sobie tworzy miejsce instancje viewmodelu (ktora zostanie dostarczona ponizej), do której będzie sie odwolywac na koncu przy przekazywaniu danych
        private readonly WynikiViewModel _wynikiViewModel;

        //to sie odpala automatycznie jak tworzy sie mainviewmodel to do niego przypisuje sie wynikiviewmodel
        public MainViewModel(WynikiViewModel wynikiViewModel)
        {
            //do tej zadeklarowanej wyzej instancji wsadzany jest wynikiViewModel dzieki temu ze mamy to w program.cs
            _wynikiViewModel = wynikiViewModel;
        }


        [ObservableProperty]
        string waga;

        [ObservableProperty]
        string wzrost;

        [ObservableProperty]
        string kolor = "Red";

        partial void OnWagaChanged(string value)
        { walidacjaButtona(); }

        partial void OnWzrostChanged(string value)
        { walidacjaButtona(); }


        public void walidacjaButtona()
        {
            if (!double.TryParse(Waga, out double _waga) || !double.TryParse(Wzrost, out double _wzrost))
            {
                Kolor = "Red";
            }
            else
            {
                Kolor = "Green";
            }
        }


        [RelayCommand]
        public async Task Oblicz()
        {
            if (kolor == "Green")
            {
                double bmi = double.Parse(Waga) / Math.Pow(double.Parse(Wzrost) / 100.0, 2);

                string wynik = "";
                string kolorwyniku = "";

                if (bmi < 18.5)
                {
                    wynik = "Niedowaga";
                    kolorwyniku = "Orange";
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    wynik = "Norma";
                    kolorwyniku = "Green";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    wynik = "Nadwaga";
                    kolorwyniku = "Orange";
                }
                else
                {
                    wynik = "Otyłość";
                    kolorwyniku = "Red";
                }

                //dzieki temu ze wyzej sobie zadeklarowalismy jeden wynikiviewmodel a nie za kazdym razem tworzymy nowy to mozemy do niego wrzucic dane
                _wynikiViewModel.Bmi = $"BMI: {bmi:F2}";
                _wynikiViewModel.Wynik = wynik;
                _wynikiViewModel.KolorWyniku = kolorwyniku;

                await Shell.Current.GoToAsync("//WynikiPage");

            }
        }
    }
}
