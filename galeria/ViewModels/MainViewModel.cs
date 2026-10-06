using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace galeria.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string path = $"img_0.png";

        [ObservableProperty]
        string title = "Zamek Królewski w Warszawie";

        [ObservableProperty]
        string opis = "Zamek Królewski w Warszawie to historyczny zamek położony w centrum Warszawy, będący dawną rezydencją królów Polski. Zamek został zniszczony podczas II wojny światowej, a następnie odbudowany w latach 1971-1984. Obecnie pełni funkcję muzeum i jest jednym z najważniejszych zabytków stolicy.";

        [ObservableProperty]
        string city = "Warszawa";

        [ObservableProperty]
        int likes = 0;

        int likes0 = 0;

        int likes1 = 0;

        int likes2 = 0;

        int likes3 = 0;

        int likes4 = 0;

        int photoIndex = 0;

        [RelayCommand]
        public async Task like()
        {
            if (photoIndex == 0)
            {
                likes0 += 1;
                Likes = likes0;
            }
            if (photoIndex == 1)
            {
                likes1 += 1;
                Likes = likes1;
            }
            if (photoIndex == 2)
            {
                likes2 += 1;
                Likes = likes2;
            }
            if (photoIndex == 3)
            {
                likes3 += 1;
                Likes = likes3;
            }
            if (photoIndex == 4)
            {
                likes4 += 1;
                Likes = likes4;
            }
        }

        [RelayCommand]
        public async Task unlike()
        {
            if (photoIndex == 0)
            {
                if (likes0 != 0)
                {
                    likes0 -= 1;
                    Likes = likes0;
                }

            }
            if (photoIndex == 1)
            {
                if (likes1 != 0)
                {
                    likes1 -= 1;
                    Likes = likes1;
                }
            }
            if (photoIndex == 2)
            {
                if (likes2 != 0)
                {
                    likes2 -= 1;
                    Likes = likes2;
                }
            }
            if (photoIndex == 3)
            {
                if (likes3 != 0)
                {
                    likes3 -= 1;
                    Likes = likes3;
                }
            }
            if (photoIndex == 4)
            {
                if (likes4 != 0)
                {
                    likes4 -= 1;
                    Likes = likes4;
                }
            }
        }


        [RelayCommand]
        public async Task next()
        {
            if (photoIndex == 4)
            {
                photoIndex = 0;
            }
            else
            {
                photoIndex += 1;
            }

            Path = $"img_{photoIndex}.png";




            if (photoIndex == 0)
            {
                Title = "Zamek Królewski w Warszawie";
                Opis = "Zamek Królewski w Warszawie to historyczny zamek położony w centrum Warszawy, będący dawną rezydencją królów Polski. Zamek został zniszczony podczas II wojny światowej, a następnie odbudowany w latach 1971-1984. Obecnie pełni funkcję muzeum i jest jednym z najważniejszych zabytków stolicy.";
                City = "Warszawa";
                Likes = likes0;
            }
            if (photoIndex == 1)
            {
                Title = "Zamek w Malborku";
                Opis = "Zamek w Malborku to zabytek renesansowy położony w Malborku, w województwie kujawsko-pomorskim. Zamek był rezydencją magnatów, a obecnie pełni funkcję muzeum.";
                City = "Malbork";
                Likes = likes1;
            }
            if (photoIndex == 2)
            {
                Title = "Żuraw w Gdańsku";
                Opis = "Żuraw w Gdańsku to zabytkowy dźwig portowy położony nad Motławą, będący jednym z symboli miasta. Żuraw został zbudowany w XIV wieku i pełnił funkcję dźwigu do podnoszenia towarów oraz bramy miejskiej. Obecnie jest częścią Muzeum Morskiego i stanowi atrakcję turystyczną.";
                City = "Gdańsk";
                Likes = likes2;
            }
            if (photoIndex == 3)
            {
                Title = "Smok Wawelski";
                Opis = "Smok Wawelski to legendarne stworzenie z polskiej mitologii, które według legendy mieszkało w jaskini pod Wawelem w Krakowie. Smok był postrachem mieszkańców miasta, aż do momentu, gdy został pokonany przez szewca Skubę, który podstępem nakarmił go siarką. Dziś Smok Wawelski jest symbolem Krakowa i znajduje się w formie rzeźby przy wejściu do Smoczej Jamy.";
                City = "Kraków";
                Likes = likes3;
            }
            if (photoIndex == 4)
            {
                Title = "Zamek Królewski na Wawelu";
                Opis = "Zamek królewski na Wawelu to zabytek architektury położony w Krakowie, będący dawną rezydencją królów Polski. Zamek został zbudowany w XIV wieku i pełnił funkcję siedziby królewskiej oraz centrum administracyjnego. Obecnie jest muzeum i jednym z najważniejszych zabytków Krakowa.";
                City = "Kraków";
                Likes = likes4;
            }

        }

        [RelayCommand]
        public async Task prev()
        {
            if (photoIndex == 0)
            {
                photoIndex = 4;
            }
            else
            {
                photoIndex -= 1;
            }

            Path = $"img_{photoIndex}.png";


            if (photoIndex == 0)
            {
                Title = "Zamek Królewski w Warszawie";
                Opis = "Zamek Królewski w Warszawie to historyczny zamek położony w centrum Warszawy, będący dawną rezydencją królów Polski. Zamek został zniszczony podczas II wojny światowej, a następnie odbudowany w latach 1971-1984. Obecnie pełni funkcję muzeum i jest jednym z najważniejszych zabytków stolicy.";
                City = "Warszawa";
                Likes = likes0;
            }
            if (photoIndex == 1)
            {
                Title = "Zamek w Malborku";
                Opis = "Zamek w Malborku to zabytek renesansowy położony w Malborku, w województwie kujawsko-pomorskim. Zamek był rezydencją magnatów, a obecnie pełni funkcję muzeum.";
                City = "Malbork";
                Likes = likes1;
            }
            if (photoIndex == 2)
            {
                Title = "Żuraw w Gdańsku";
                Opis = "Żuraw w Gdańsku to zabytkowy dźwig portowy położony nad Motławą, będący jednym z symboli miasta. Żuraw został zbudowany w XIV wieku i pełnił funkcję dźwigu do podnoszenia towarów oraz bramy miejskiej. Obecnie jest częścią Muzeum Morskiego i stanowi atrakcję turystyczną.";
                City = "Gdańsk";
                Likes = likes2;
            }
            if (photoIndex == 3)
            {
                Title = "Smok Wawelski";
                Opis = "Smok Wawelski to legendarne stworzenie z polskiej mitologii, które według legendy mieszkało w jaskini pod Wawelem w Krakowie. Smok był postrachem mieszkańców miasta, aż do momentu, gdy został pokonany przez szewca Skubę, który podstępem nakarmił go siarką. Dziś Smok Wawelski jest symbolem Krakowa i znajduje się w formie rzeźby przy wejściu do Smoczej Jamy.";
                City = "Kraków";
                Likes = likes3;
            }
            if (photoIndex == 4)
            {
                Title = "Zamek Królewski na Wawelu";
                Opis = "Zamek królewski na Wawelu to zabytek architektury położony w Krakowie, będący dawną rezydencją królów Polski. Zamek został zbudowany w XIV wieku i pełnił funkcję siedziby królewskiej oraz centrum administracyjnego. Obecnie jest muzeum i jednym z najważniejszych zabytków Krakowa.";
                City = "Kraków";
                Likes = likes4;
            }

        }

        [RelayCommand]
        public async Task loc()
        {
            await Shell.Current.DisplayAlert("Lokalizacja", city, "OK");
        }










    }
}
