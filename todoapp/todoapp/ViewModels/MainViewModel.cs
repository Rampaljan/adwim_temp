using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace todoapp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string pole = "pole oryginal";

        [ObservableProperty]
        string odpowiedz = "odpowiedź oryginal";

        [RelayCommand]
        public async Task dupa()
        {
            await Shell.Current.DisplayAlert("Tytuł", "Treść", "OK");
            Odpowiedz = Pole;
        }
    }
}
