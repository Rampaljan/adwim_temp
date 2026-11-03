using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit;

using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.App.ViewModels
{
    public partial class CategoryListViewModel : ObservableObject
    {
        [ObservableProperty]
        string pole;

        [ObservableProperty]
        string odpowiedz;

        [RelayCommand]
        public async Task dupa()
        {
            await Shell.Current.DisplayAlert("dupa", odpowiedz, "ok");
            odpowiedz = pole;
        }
    }
}
