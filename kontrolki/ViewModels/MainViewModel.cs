using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace kontrolki.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string pole;
        [ObservableProperty]
        string odpowiedz;

        [RelayCommand]

        public async Task dupa()
        {
            await Shell.Current.DisplayAlert("dupa", odpowiedz, "ok");
            Odpowiedz = Pole;
        }

    }
}
