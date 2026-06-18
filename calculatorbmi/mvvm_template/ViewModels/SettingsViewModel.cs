using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace mvvm_template.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _czyJasny;

        partial void OnCzyJasnyChanged(bool value)
        {
            //dzieki grzesiu za podrzucenie pomyslu bo wczesniej robilem zamienianie bcg i txtcolor na kazdym content pagu i do resources dodawalem nowe kolory i w definicjach content pagea dawalem odniesienia do static resource, ale juz jest spk, bo jak widac są domyslne funkcje na apptheme
            Application.Current!.UserAppTheme = value ? AppTheme.Light : AppTheme.Dark;
        }

        [RelayCommand]
        public async Task Wroc()
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}