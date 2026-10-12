using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace memory.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly GameEasyViewModel _gameEasyViewModel;
        private readonly GameMidViewModel _gameMidViewModel;
        private readonly GameHardViewModel _gameHardViewModel;

        public MainViewModel(GameEasyViewModel gameEasyViewModel, GameMidViewModel gameMidViewModel, GameHardViewModel gameHardViewModel)
        {
            _gameEasyViewModel = gameEasyViewModel;
            _gameMidViewModel = gameMidViewModel;
            _gameHardViewModel = gameHardViewModel;
        }

        [ObservableProperty]
        string level;

        [RelayCommand]
        public async Task nowagra()
        {

            if (level == "Łatwy")
            {
                _gameEasyViewModel.Level = level;
                await Shell.Current.GoToAsync("//GameEasyPage");
            }
            else if (level == "Średni")
            {
                _gameMidViewModel.Level = level;
                await Shell.Current.GoToAsync("//GameMidPage");
            }
            else if (level == "Trudny")
            {
                _gameHardViewModel.Level = level;
                await Shell.Current.GoToAsync("//GameHardPage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Komunikat", "Nie wybrano trybu, wybierz poziom trudności gry, aby przejść dalej", "Ok");
            }
        }


    }
}
