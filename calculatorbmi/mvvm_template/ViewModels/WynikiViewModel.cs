using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace mvvm_template.ViewModels
{

    //i on to fajnie teraz dostaje juz z mainviewmodela przez DI
    public partial class WynikiViewModel : ObservableObject
    {
        [ObservableProperty]
        string bmi;

        [ObservableProperty]
        string wynik;

        [ObservableProperty]
        string kolorWyniku = "#1f1f1f";

        [RelayCommand]
        public async Task Wroc()
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}