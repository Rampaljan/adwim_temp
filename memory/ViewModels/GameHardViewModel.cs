using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memory.ViewModels
{
    public partial class GameHardViewModel : ObservableObject
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
        string img9 = "question_mark.png";
        string actualImg9 = "";
        bool block9 = false;

        [ObservableProperty]
        string img10 = "question_mark.png";
        string actualImg10 = "";
        bool block10 = false;

        [ObservableProperty]
        string img11 = "question_mark.png";
        string actualImg11 = "";
        bool block11 = false;

        [ObservableProperty]
        string img12 = "question_mark.png";
        string actualImg12 = "";
        bool block12 = false;

        [ObservableProperty]
        string img13 = "question_mark.png";
        string actualImg13 = "";
        bool block13 = false;

        [ObservableProperty]
        string img14 = "question_mark.png";
        string actualImg14 = "";
        bool block14 = false;

        [ObservableProperty]
        string img15 = "question_mark.png";
        string actualImg15 = "";
        bool block15 = false;

        [ObservableProperty]
        string img16 = "question_mark.png";
        string actualImg16 = "";
        bool block16 = false;








        [RelayCommand]
        public async Task back()
        {
            await Shell.Current.GoToAsync("//MainPage");
        }


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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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

            if (flag != 2 && !block2) //flag != n && !blockn
            {
                if (Img2 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img2 = actualImg2; //Imgn = actualImgn
                        flag = 2;
                    }
                    else
                    {
                        Counter += 1;
                        Img2 = actualImg2; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg2) //actualImgn
                        {


                            block2 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img2 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click3()
        {
            if (IsBusy) return;

            if (flag != 3 && !block3) //flag != n && !blockn
            {
                if (Img3 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img3 = actualImg3; //Imgn = actualImgn
                        flag = 3;
                    }
                    else
                    {
                        Counter += 1;
                        Img3 = actualImg3; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg3) //actualImgn
                        {


                            block3 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img3 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click4()
        {
            if (IsBusy) return;

            if (flag != 4 && !block4) //flag != n && !blockn
            {
                if (Img4 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img4 = actualImg4; //Imgn = actualImgn
                        flag = 4;
                    }
                    else
                    {
                        Counter += 1;
                        Img4 = actualImg4; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg4) //actualImgn
                        {


                            block4 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img4 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click5()
        {
            if (IsBusy) return;

            if (flag != 5 && !block5) //flag != n && !blockn
            {
                if (Img5 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img5 = actualImg5; //Imgn = actualImgn
                        flag = 5;
                    }
                    else
                    {
                        Counter += 1;
                        Img5 = actualImg5; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg5) //actualImgn
                        {


                            block5 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img5 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click6()
        {
            if (IsBusy) return;

            if (flag != 6 && !block6) //flag != n && !blockn
            {
                if (Img6 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img6 = actualImg6; //Imgn = actualImgn
                        flag = 6;
                    }
                    else
                    {
                        Counter += 1;
                        Img6 = actualImg6; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg6) //actualImgn
                        {


                            block6 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img6 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click7()
        {
            if (IsBusy) return;

            if (flag != 7 && !block7) //flag != n && !blockn
            {
                if (Img7 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img7 = actualImg7; //Imgn = actualImgn
                        flag = 7;
                    }
                    else
                    {
                        Counter += 1;
                        Img7 = actualImg7; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg7) //actualImgn
                        {


                            block7 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img7 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click8()
        {
            if (IsBusy) return;

            if (flag != 8 && !block8) //flag != n && !blockn
            {
                if (Img8 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img8 = actualImg8; //Imgn = actualImgn
                        flag = 8;
                    }
                    else
                    {
                        Counter += 1;
                        Img8 = actualImg8; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg8) //actualImgn
                        {


                            block8 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img8 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click9()
        {
            if (IsBusy) return;

            if (flag != 9 && !block9) //flag != n && !blockn
            {
                if (Img9 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img9 = actualImg9; //Imgn = actualImgn
                        flag = 9;
                    }
                    else
                    {
                        Counter += 1;
                        Img9 = actualImg9; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg9) //actualImgn
                        {


                            block9 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img9 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click10()
        {
            if (IsBusy) return;

            if (flag != 10 && !block10) //flag != n && !blockn
            {
                if (Img10 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img10 = actualImg10; //Imgn = actualImgn
                        flag = 10;
                    }
                    else
                    {
                        Counter += 1;
                        Img10 = actualImg10; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg10) //actualImgn
                        {


                            block10 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img10 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click11()
        {
            if (IsBusy) return;

            if (flag != 11 && !block11) //flag != n && !blockn
            {
                if (Img11 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img11 = actualImg11; //Imgn = actualImgn
                        flag = 11;
                    }
                    else
                    {
                        Counter += 1;
                        Img11 = actualImg11; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg11) //actualImgn
                        {


                            block11 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img11 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click12()
        {
            if (IsBusy) return;

            if (flag != 12 && !block12) //flag != n && !blockn
            {
                if (Img12 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img12 = actualImg12; //Imgn = actualImgn
                        flag = 12;
                    }
                    else
                    {
                        Counter += 1;
                        Img12 = actualImg12; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg12) //actualImgn
                        {


                            block12 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img12 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click13()
        {
            if (IsBusy) return;

            if (flag != 13 && !block13) //flag != n && !blockn
            {
                if (Img13 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img13 = actualImg13; //Imgn = actualImgn
                        flag = 13;
                    }
                    else
                    {
                        Counter += 1;
                        Img13 = actualImg13; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg13) //actualImgn
                        {


                            block13 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img13 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click14()
        {
            if (IsBusy) return;

            if (flag != 14 && !block14) //flag != n && !blockn
            {
                if (Img14 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img14 = actualImg14; //Imgn = actualImgn
                        flag = 14;
                    }
                    else
                    {
                        Counter += 1;
                        Img14 = actualImg14; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg14) //actualImgn
                        {


                            block14 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img14 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click15()
        {
            if (IsBusy) return;

            if (flag != 15 && !block15) //flag != n && !blockn
            {
                if (Img15 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img15 = actualImg15; //Imgn = actualImgn
                        flag = 15;
                    }
                    else
                    {
                        Counter += 1;
                        Img15 = actualImg15; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg15) //actualImgn
                        {


                            block15 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img15 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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
        public async Task click16()
        {
            if (IsBusy) return;

            if (flag != 16 && !block16) //flag != n && !blockn
            {
                if (Img16 == "question_mark.png") //Imgn
                {
                    if (flag == 0)
                    {
                        Img16 = actualImg16; //Imgn = actualImgn
                        flag = 16;
                    }
                    else
                    {
                        Counter += 1;
                        Img16 = actualImg16; //Imgn = actualImgn

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
                            9 => actualImg9,
                            10 => actualImg10,
                            11 => actualImg11,
                            12 => actualImg12,
                            13 => actualImg13,
                            14 => actualImg14,
                            15 => actualImg15,
                            16 => actualImg16,
                            _ => ""
                        };//tu dodać wiecej elementów, tyle ile jest obrazków

                        if (otherActual == actualImg16) //actualImgn
                        {


                            block16 = true; //blockn

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
                                case 9: block9 = true; break;
                                case 10: block10 = true; break;
                                case 11: block11 = true; break;
                                case 12: block12 = true; break;
                                case 13: block13 = true; break;
                                case 14: block14 = true; break;
                                case 15: block15 = true; break;
                                case 16: block16 = true; break;
                            }//tu dodać wiecej elementów, tyle ile jest obrazków

                            flag = 0;

                            //finished?
                            if (block1 && block2 && block3 && block4 && block5 && block6 && block7 && block8 && block9 && block10 && block11 && block12 && block13 && block14 && block15 && block16) //dodać blocki
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

                                Img16 = "question_mark.png"; //Imgn

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
                                    case 9: Img9 = "question_mark.png"; break;
                                    case 10: Img10 = "question_mark.png"; break;
                                    case 11: Img11 = "question_mark.png"; break;
                                    case 12: Img12 = "question_mark.png"; break;
                                    case 13: Img13 = "question_mark.png"; break;
                                    case 14: Img14 = "question_mark.png"; break;
                                    case 15: Img15 = "question_mark.png"; break;
                                    case 16: Img16 = "question_mark.png"; break;
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

        public GameHardViewModel()
        {
            // przypisanie pierwsze, a pozniej tasowanie
            var obrazki = new List<string>
                {
                    "a.png", "a.png",
                    "b.png", "b.png",
                    "c.png", "c.png",
                    "d.png", "d.png",
                    "e.png", "e.png",
                    "f.png", "f.png",
                    "g.png", "g.png",
                    "h.png", "h.png",
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
            actualImg9 = obrazki[8];
            actualImg10 = obrazki[9];
            actualImg11 = obrazki[10];
            actualImg12 = obrazki[11];
            actualImg13 = obrazki[12];
            actualImg14 = obrazki[13];
            actualImg15 = obrazki[14];
            actualImg16 = obrazki[15];
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
