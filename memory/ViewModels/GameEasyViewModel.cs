using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memory.ViewModels
{
    public partial class GameEasyViewModel : ObservableObject
    {
        private PeriodicTimer _timer;
        private Task _timerTask;
        private bool _finished = false;
        private DateTime _startTime;

        [ObservableProperty]
        TimeSpan elapsed;

        [ObservableProperty]
        string level;

        [ObservableProperty]
        string img1 = "question_mark.png";
        string actualImg1 = "";
        bool block1 = false;

        [ObservableProperty]
        string img2 = "question_mark.png";
        string actualImg2 = "";
        bool block2 = false;

        [ObservableProperty]
        string img3 = "question_mark.png";
        string actualImg3 = "";
        bool block3 = false;

        [ObservableProperty]
        string img4 = "question_mark.png";
        string actualImg4 = "";
        bool block4 = false;

        [ObservableProperty]
        string img5 = "question_mark.png";
        string actualImg5 = "";
        bool block5 = false;

        [ObservableProperty]
        string img6 = "question_mark.png";
        string actualImg6 = "";
        bool block6 = false;

        [ObservableProperty]
        string img7 = "question_mark.png";
        string actualImg7 = "";
        bool block7 = false;

        [ObservableProperty]
        string img8 = "question_mark.png";
        string actualImg8 = "";
        bool block8 = false;

        [ObservableProperty]
        bool isBusy;

        [ObservableProperty]
        int counter = 0;
        int flag = 0;

        [RelayCommand]
        public async Task click1()
        {
            if (IsBusy) return;

            if (flag != 1 && !block1) //flag != n && !blockn
            {
                if (Img1 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img1 = actualImg1; //Imgn = actualImgn
                        flag = 1;
                    }
                    else
                    {
                        Counter += 1;
                        Img1 = actualImg1; //Imgn = actualImgn

                        string otherActual = flag switch
                        {
                            1 => actualImg1,
                            2 => actualImg2,
                            3 => actualImg3,
                            4 => actualImg4,
                            5 => actualImg5,
                            6 => actualImg6,
                            7 => actualImg7,
                            8 => actualImg8,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg1) //actualImgn
                        {


                            block1 = true; //blockn

                            switch (flag)
                            {
                                case 1: block1 = true; break;
                                case 2: block2 = true; break;
                                case 3: block3 = true; break;
                                case 4: block4 = true; break;
                                case 5: block5 = true; break;
                                case 6: block6 = true; break;
                                case 7: block7 = true; break;
                                case 8: block8 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8) //dodać blocki
                            {
                                await HandleWin();
                            }
                        }
                        else
                        {
                            IsBusy = true;
                            try
                            {
                                await Task.Delay(2000);

                                Img1 = "question_mark.png"; //Imgn

                                switch (flag)
                                {
                                    case 1: Img1 = "question_mark.png"; break;
                                    case 2: Img2 = "question_mark.png"; break;
                                    case 3: Img3 = "question_mark.png"; break;
                                    case 4: Img4 = "question_mark.png"; break;
                                    case 5: Img5 = "question_mark.png"; break;
                                    case 6: Img6 = "question_mark.png"; break;
                                    case 7: Img7 = "question_mark.png"; break;
                                    case 8: Img8 = "question_mark.png"; break;
                                }//tu dodać wiecej elementów, tyle ile jest obrazków

                                flag = 0;
                            }
                            finally
                            {
                                IsBusy = false;
                            }
                        }
                    }
                }
            }

        }


        [RelayCommand]
        public async Task click2()
        {
            if (IsBusy) return;

            if (flag != 2 && !block2)
            {
                if (Img2 == "question_mark.png")
                {
                    if (flag == 0)
                    {
                        Img2 = actualImg2;
                        flag = 2;
                    }
                    else
                    {
                        Counter += 1;
                        Img2 = actualImg2; //tu do zmiany

                        string otherActual = flag switch
                        {
                            1 => actualImg1,
                            2 => actualImg2,
                            3 => actualImg3,
                            4 => actualImg4,
                            5 => actualImg5,
                            6 => actualImg6,
                            7 => actualImg7,
                            8 => actualImg8,
                            _ => ""
                        };

                        if (otherActual == actualImg2) //tu do zmiany
                        {
                            block2 = true; //tu do zmiany

                            switch (flag)
                            {
                                case 1: block1 = true; break;
                                case 2: block2 = true; break;
                                case 3: block3 = true; break;
                                case 4: block4 = true; break;
                                case 5: block5 = true; break;
                                case 6: block6 = true; break;
                                case 7: block7 = true; break;
                                case 8: block8 = true; break;
                            }
                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8)
                            {
                                await HandleWin();
                            }
                        }
                        else
                        {
                            IsBusy = true;
                            try
                            {
                                await Task.Delay(2000);

                                Img2 = "question_mark.png"; //tu do zmiany

                                switch (flag)
                                {
                                    case 1: Img1 = "question_mark.png"; break;
                                    case 2: Img2 = "question_mark.png"; break;
                                    case 3: Img3 = "question_mark.png"; break;
                                    case 4: Img4 = "question_mark.png"; break;
                                    case 5: Img5 = "question_mark.png"; break;
                                    case 6: Img6 = "question_mark.png"; break;
                                    case 7: Img7 = "question_mark.png"; break;
                                    case 8: Img8 = "question_mark.png"; break;
                                }

                                flag = 0;
                            }
                            finally
                            {
                                IsBusy = false;
                            }
                        }
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click3()
        {
            if (IsBusy) return;

            if (flag != 3 && !block3)
            {
                if (Img3 == "question_mark.png")
                {
                    if (flag == 0)
                    {
                        Img3 = actualImg3;
                        flag = 3;
                    }
                    else
                    {
                        Counter += 1;
                        Img3 = actualImg3; //tu do zmiany

                        string otherActual = flag switch
                        {
                            1 => actualImg1,
                            2 => actualImg2,
                            3 => actualImg3,
                            4 => actualImg4,
                            5 => actualImg5,
                            6 => actualImg6,
                            7 => actualImg7,
                            8 => actualImg8,
                            _ => ""
                        };

                        if (otherActual == actualImg3) //tu do zmiany
                        {
                            block3 = true; //tu do zmiany

                            switch (flag)
                            {
                                case 1: block1 = true; break;
                                case 2: block2 = true; break;
                                case 3: block3 = true; break;
                                case 4: block4 = true; break;
                                case 5: block5 = true; break;
                                case 6: block6 = true; break;
                                case 7: block7 = true; break;
                                case 8: block8 = true; break;
                            }
                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8)
                            {
                                await HandleWin();
                            }
                        }
                        else
                        {
                            IsBusy = true;
                            try
                            {
                                await Task.Delay(2000);

                                Img3 = "question_mark.png"; //tu do zmiany

                                switch (flag)
                                {
                                    case 1: Img1 = "question_mark.png"; break;
                                    case 2: Img2 = "question_mark.png"; break;
                                    case 3: Img3 = "question_mark.png"; break;
                                    case 4: Img4 = "question_mark.png"; break;
                                    case 5: Img5 = "question_mark.png"; break;
                                    case 6: Img6 = "question_mark.png"; break;
                                    case 7: Img7 = "question_mark.png"; break;
                                    case 8: Img8 = "question_mark.png"; break;
                                }

                                flag = 0;
                            }
                            finally
                            {
                                IsBusy = false;
                            }
                        }
                    }
                }
            }

        }

        [RelayCommand]
        public async Task click4()
        {
            if (IsBusy) return;

            if (flag != 4 && !block4)
            {
                if (Img4 == "question_mark.png")
                {
                    if (flag == 0)
                    {
                        Img4 = actualImg4;
                        flag = 4;
                    }
                    else
                    {
                        Counter += 1;
                        Img4 = actualImg4; //tu do zmiany

                        string otherActual = flag switch
                        {
                            1 => actualImg1,
                            2 => actualImg2,
                            3 => actualImg3,
                            4 => actualImg4,
                            5 => actualImg5,
                            6 => actualImg6,
                            7 => actualImg7,
                            8 => actualImg8,
                            _ => ""
                        };

                        if (otherActual == actualImg4) //tu do zmiany
                        {
                            block4 = true; //tu do zmiany

                            switch (flag)
                            {
                                case 1: block1 = true; break;
                                case 2: block2 = true; break;
                                case 3: block3 = true; break;
                                case 4: block4 = true; break;
                                case 5: block5 = true; break;
                                case 6: block6 = true; break;
                                case 7: block7 = true; break;
                                case 8: block8 = true; break;
                            }
                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8)
                            {
                                await HandleWin();
                            }
                        }
                        else
                        {
                            IsBusy = true;
                            try
                            {
                                await Task.Delay(2000);

                                Img4 = "question_mark.png"; //tu do zmiany

                                switch (flag)
                                {
                                    case 1: Img1 = "question_mark.png"; break;
                                    case 2: Img2 = "question_mark.png"; break;
                                    case 3: Img3 = "question_mark.png"; break;
                                    case 4: Img4 = "question_mark.png"; break;
                                    case 5: Img5 = "question_mark.png"; break;
                                    case 6: Img6 = "question_mark.png"; break;
                                    case 7: Img7 = "question_mark.png"; break;
                                    case 8: Img8 = "question_mark.png"; break;
                                }

                                flag = 0;
                            }
                            finally
                            {
                                IsBusy = false;
                            }
                        }
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click5()
        {
            if (IsBusy) return;

            if (flag != 5 && !block5)
            {
                if (Img5 == "question_mark.png")
                {
                    if (flag == 0)
                    {
                        Img5 = actualImg5;
                        flag = 5;
                    }
                    else
                    {
                        Counter += 1;
                        Img5 = actualImg5; //tu do zmiany

                        string otherActual = flag switch
                        {
                            1 => actualImg1,
                            2 => actualImg2,
                            3 => actualImg3,
                            4 => actualImg4,
                            5 => actualImg5,
                            6 => actualImg6,
                            7 => actualImg7,
                            8 => actualImg8,
                            _ => ""
                        };

                        if (otherActual == actualImg5) //tu do zmiany
                        {
                            block5 = true; //tu do zmiany

                            switch (flag)
                            {
                                case 1: block1 = true; break;
                                case 2: block2 = true; break;
                                case 3: block3 = true; break;
                                case 4: block4 = true; break;
                                case 5: block5 = true; break;
                                case 6: block6 = true; break;
                                case 7: block7 = true; break;
                                case 8: block8 = true; break;
                            }
                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8)
                            {
                                await HandleWin();
                            }
                        }
                        else
                        {
                            IsBusy = true;
                            try
                            {
                                await Task.Delay(2000);

                                Img5 = "question_mark.png"; //tu do zmiany

                                switch (flag)
                                {
                                    case 1: Img1 = "question_mark.png"; break;
                                    case 2: Img2 = "question_mark.png"; break;
                                    case 3: Img3 = "question_mark.png"; break;
                                    case 4: Img4 = "question_mark.png"; break;
                                    case 5: Img5 = "question_mark.png"; break;
                                    case 6: Img6 = "question_mark.png"; break;
                                    case 7: Img7 = "question_mark.png"; break;
                                    case 8: Img8 = "question_mark.png"; break;
                                }

                                flag = 0;
                            }
                            finally
                            {
                                IsBusy = false;
                            }
                        }
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click6()
        {
            if (IsBusy) return;

            if (flag != 6 && !block6)
            {
                if (Img6 == "question_mark.png")
                {
                    if (flag == 0)
                    {
                        Img6 = actualImg6;
                        flag = 6;
                    }
                    else
                    {
                        Counter += 1;
                        Img6 = actualImg6; //tu do zmiany

                        string otherActual = flag switch
                        {
                            1 => actualImg1,
                            2 => actualImg2,
                            3 => actualImg3,
                            4 => actualImg4,
                            5 => actualImg5,
                            6 => actualImg6,
                            7 => actualImg7,
                            8 => actualImg8,
                            _ => ""
                        };

                        if (otherActual == actualImg6) //tu do zmiany
                        {
                            block6 = true; //tu do zmiany

                            switch (flag)
                            {
                                case 1: block1 = true; break;
                                case 2: block2 = true; break;
                                case 3: block3 = true; break;
                                case 4: block4 = true; break;
                                case 5: block5 = true; break;
                                case 6: block6 = true; break;
                                case 7: block7 = true; break;
                                case 8: block8 = true; break;
                            }
                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8)
                            {
                                await HandleWin();
                            }
                        }
                        else
                        {
                            IsBusy = true;
                            try
                            {
                                await Task.Delay(2000);

                                Img6 = "question_mark.png"; //tu do zmiany

                                switch (flag)
                                {
                                    case 1: Img1 = "question_mark.png"; break;
                                    case 2: Img2 = "question_mark.png"; break;
                                    case 3: Img3 = "question_mark.png"; break;
                                    case 4: Img4 = "question_mark.png"; break;
                                    case 5: Img5 = "question_mark.png"; break;
                                    case 6: Img6 = "question_mark.png"; break;
                                    case 7: Img7 = "question_mark.png"; break;
                                    case 8: Img8 = "question_mark.png"; break;
                                }

                                flag = 0;
                            }
                            finally
                            {
                                IsBusy = false;
                            }
                        }
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click7()
        {
            if (IsBusy) return;

            if (flag != 7 && !block7)
            {
                if (Img7 == "question_mark.png")
                {
                    if (flag == 0)
                    {
                        Img7 = actualImg7;
                        flag = 7;
                    }
                    else
                    {
                        Counter += 1;
                        Img7 = actualImg7; //tu do zmiany

                        string otherActual = flag switch
                        {
                            1 => actualImg1,
                            2 => actualImg2,
                            3 => actualImg3,
                            4 => actualImg4,
                            5 => actualImg5,
                            6 => actualImg6,
                            7 => actualImg7,
                            8 => actualImg8,
                            _ => ""
                        };

                        if (otherActual == actualImg7) //tu do zmiany
                        {
                            block7 = true; //tu do zmiany

                            switch (flag)
                            {
                                case 1: block1 = true; break;
                                case 2: block2 = true; break;
                                case 3: block3 = true; break;
                                case 4: block4 = true; break;
                                case 5: block5 = true; break;
                                case 6: block6 = true; break;
                                case 7: block7 = true; break;
                                case 8: block8 = true; break;
                            }
                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8)
                            {
                                await HandleWin();
                            }
                        }
                        else
                        {
                            IsBusy = true;
                            try
                            {
                                await Task.Delay(2000);

                                Img7 = "question_mark.png"; //tu do zmiany

                                switch (flag)
                                {
                                    case 1: Img1 = "question_mark.png"; break;
                                    case 2: Img2 = "question_mark.png"; break;
                                    case 3: Img3 = "question_mark.png"; break;
                                    case 4: Img4 = "question_mark.png"; break;
                                    case 5: Img5 = "question_mark.png"; break;
                                    case 6: Img6 = "question_mark.png"; break;
                                    case 7: Img7 = "question_mark.png"; break;
                                    case 8: Img8 = "question_mark.png"; break;
                                }

                                flag = 0;
                            }
                            finally
                            {
                                IsBusy = false;
                            }
                        }
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click8()
        {
            if (IsBusy) return;

            if (flag != 8 && !block8)
            {
                if (Img8 == "question_mark.png")
                {
                    if (flag == 0)
                    {
                        Img8 = actualImg8;
                        flag = 8;
                    }
                    else
                    {
                        Counter += 1;
                        Img8 = actualImg8; //tu do zmiany

                        string otherActual = flag switch
                        {
                            1 => actualImg1,
                            2 => actualImg2,
                            3 => actualImg3,
                            4 => actualImg4,
                            5 => actualImg5,
                            6 => actualImg6,
                            7 => actualImg7,
                            8 => actualImg8,
                            _ => ""
                        };

                        if (otherActual == actualImg8) //tu do zmiany
                        {
                            block8 = true; //tu do zmiany

                            switch (flag)
                            {
                                case 1: block1 = true; break;
                                case 2: block2 = true; break;
                                case 3: block3 = true; break;
                                case 4: block4 = true; break;
                                case 5: block5 = true; break;
                                case 6: block6 = true; break;
                                case 7: block7 = true; break;
                                case 8: block8 = true; break;
                            }
                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8)
                            {
                                await HandleWin();
                            }
                        }
                        else
                        {
                            IsBusy = true;
                            try
                            {
                                await Task.Delay(2000);

                                Img8 = "question_mark.png"; //tu do zmiany

                                switch (flag)
                                {
                                    case 1: Img1 = "question_mark.png"; break;
                                    case 2: Img2 = "question_mark.png"; break;
                                    case 3: Img3 = "question_mark.png"; break;
                                    case 4: Img4 = "question_mark.png"; break;
                                    case 5: Img5 = "question_mark.png"; break;
                                    case 6: Img6 = "question_mark.png"; break;
                                    case 7: Img7 = "question_mark.png"; break;
                                    case 8: Img8 = "question_mark.png"; break;
                                }

                                flag = 0;
                            }
                            finally
                            {
                                IsBusy = false;
                            }
                        }
                    }
                }
            }
        }


        public GameEasyViewModel()
        {
            // przypisanie pierwsze, a pozniej tasowanie
            var obrazki = new List<string>
                {
                    "a.png", "a.png",
                    "b.png", "b.png",
                    "c.png", "c.png",
                    "d.png", "d.png"
                };//tu dodać wiecej elementów, tyle ile jest obrazków

            var rng = new Random();
            for (int i = obrazki.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (obrazki[i], obrazki[j]) = (obrazki[j], obrazki[i]);
            }

            actualImg1 = obrazki[0];
            actualImg2 = obrazki[1];
            actualImg3 = obrazki[2];
            actualImg4 = obrazki[3];
            actualImg5 = obrazki[4];
            actualImg6 = obrazki[5];
            actualImg7 = obrazki[6];
            actualImg8 = obrazki[7];
            //tu dodać wiecej elementów, tyle ile jest obrazków

            //timer
            _startTime = DateTime.Now;
            _timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
            _timerTask = TimerLoop(); //Pętla jest lekka, możemy uruchomić w tym samym wątku
        }

        private async Task TimerLoop()
        {
            while (!_finished) // Nigdy nie robimy while (true) !!!
            {
                await _timer.WaitForNextTickAsync();
                if (!_finished)
                {
                    Elapsed = DateTime.Now - _startTime; // Liczymy ile upłynęło czasu od startu gry
                }
            }
        }

        private async Task HandleWin()
        {
            _finished = true;
            _timer.Dispose();

            string czas = $"{(int)Elapsed.TotalMinutes:00}:{Elapsed.Seconds:00}";
            await Shell.Current.DisplayAlert(
                "Wygrana",
                $"Gratulacje! Wygrałeś grę.\nTwój czas: {czas}\nLiczba ruchów: {Counter}",
                "Ok");

            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
