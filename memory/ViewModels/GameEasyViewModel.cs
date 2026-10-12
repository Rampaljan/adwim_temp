using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace memory.ViewModels
{
    public partial class GameEasyViewModel : ObservableObject
    {
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


        int flag = 0;


        [RelayCommand]
        public async Task click1()
        {
            if (flag != 1 && !block1)
            {
                if (Img1 == "question_mark.png")
                {
                    if (flag == 0)
                    {
                        Img1 = actualImg1;
                        flag = 1;
                    }
                    else
                    {
                        Img1 = actualImg1; //tu do zmiany

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

                        if (otherActual == actualImg1) //tu do zmiany
                        {
                            block1 = true; //tu do zmiany

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
                        }
                        else
                        {
                            await Task.Delay(2000);
                            Img1 = "question_mark.png"; //tu do zmiany
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
                    }
                }
            }

        }


        [RelayCommand]
        public async Task click2()
        {
            if(flag != 2 && !block2)
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
                        }
                        else
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
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click3()
        {
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
                        }
                        else
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
                    }
                }
            }

        }

        [RelayCommand]
        public async Task click4()
        {
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
                        }
                        else
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
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click5()
        {
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
                        }
                        else
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
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click6()
        {
            if(flag != 6 && !block6)
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
                        }
                        else
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
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click7()
        {
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
                        }
                        else
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
                    }
                }
            }
        }

        [RelayCommand]
        public async Task click8()
        {
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
                        }
                        else
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
                };

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
        }
    }
}
