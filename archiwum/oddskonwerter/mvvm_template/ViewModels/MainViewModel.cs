using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

//I am God's chosen programmer. 
//He has endowed me with divine intellect, like the authors of the Bible. It has no code I did not write. 
//It never runs code I did not write. I am the best programmer on the planet. 
//I wrote a 64-bit compiler, assembler, kernel, debugger, bootloader, graphics library, graphics-editor, editor, 
//tools like grep and a bunch of demos, including a first-person-shooter and flight simulator.

//I am the best programmer on the planet -- that's why God chose me and that should help you understand. 
//There are two kinds of programmers -- those who have written compilers and those who haven't. 
//What sounds impossible for you is not impossible for me.

// -pomysł zosi na wklejenie tego tutaj po zobaczeniu tej abominacji



namespace mvvm_template.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string odds = "-";

        [ObservableProperty]
        string size = "-";

        [ObservableProperty]
        string convertedodds = "-";

        [ObservableProperty]
        string payout = "-";

        [ObservableProperty]
        string win = "-";

        [ObservableProperty]
        bool isFromDecimal = true;
        [ObservableProperty]
        bool isFromFraction;
        [ObservableProperty]
        bool isFromAmerican;
        [ObservableProperty]
        bool isFromShares;

        [ObservableProperty]
        bool isToDecimal;
        [ObservableProperty]
        bool isToFraction;
        [ObservableProperty]
        bool isToAmerican;
        [ObservableProperty]
        bool isToShares = true;


        string convertFrom = "d";
        string convertTo = "s";

        bool _isSwapping = false;

        // From
        partial void OnIsFromDecimalChanged(bool value)
        {
            if (value && !_isSwapping)
            {
                string oldFrom = convertFrom;
                if (convertTo == "d") { SwapTo(oldFrom); convertTo = oldFrom; }
                convertFrom = "d";
                update();
            }
        }

        partial void OnIsFromFractionChanged(bool value)
        {
            if (value && !_isSwapping)
            {
                string oldFrom = convertFrom;
                if (convertTo == "f") { SwapTo(oldFrom); convertTo = oldFrom; }
                convertFrom = "f";
                update();
            }
        }

        partial void OnIsFromAmericanChanged(bool value)
        {
            if (value && !_isSwapping)
            {
                string oldFrom = convertFrom;
                if (convertTo == "a") { SwapTo(oldFrom); convertTo = oldFrom; }
                convertFrom = "a";
                update();
            }
        }

        partial void OnIsFromSharesChanged(bool value)
        {
            if (value && !_isSwapping)
            {
                string oldFrom = convertFrom;
                if (convertTo == "s") { SwapTo(oldFrom); convertTo = oldFrom; }
                convertFrom = "s";
                update();
            }
        }

        // To
        partial void OnIsToDecimalChanged(bool value)
        {
            if (value && !_isSwapping)
            {
                string oldTo = convertTo;
                if (convertFrom == "d") { SwapFrom(oldTo); convertFrom = oldTo; }
                convertTo = "d";
                update();
            }
        }

        partial void OnIsToFractionChanged(bool value)
        {
            if (value && !_isSwapping)
            {
                string oldTo = convertTo;
                if (convertFrom == "f") { SwapFrom(oldTo); convertFrom = oldTo; }
                convertTo = "f";
                update();
            }
        }

        partial void OnIsToAmericanChanged(bool value)
        {
            if (value && !_isSwapping)
            {
                string oldTo = convertTo;
                if (convertFrom == "a") { SwapFrom(oldTo); convertFrom = oldTo; }
                convertTo = "a";
                update();
            }
        }

        partial void OnIsToSharesChanged(bool value)
        {
            if (value && !_isSwapping)
            {
                string oldTo = convertTo;
                if (convertFrom == "s") { SwapFrom(oldTo); convertFrom = oldTo; }
                convertTo = "s";
                update();
            }
        }

        //SWAPY
        void SwapTo(string value)
        {
            _isSwapping = true;

            IsToDecimal = false;
            IsToFraction = false;
            IsToAmerican = false;
            IsToShares = false;

            if (value == "d") IsToDecimal = true;
            if (value == "f") IsToFraction = true;
            if (value == "a") IsToAmerican = true;
            if (value == "s") IsToShares = true;

            _isSwapping = false;
        }

        void SwapFrom(string value)
        {
            _isSwapping = true;

            IsFromDecimal = false;
            IsFromFraction = false;
            IsFromAmerican = false;
            IsFromShares = false;

            if (value == "d") IsFromDecimal = true;
            if (value == "f") IsFromFraction = true;
            if (value == "a") IsFromAmerican = true;
            if (value == "s") IsFromShares = true;

            _isSwapping = false;
        }


        //jak sie entry od usera zmieniają to tez sie liczy na nowo
        partial void OnOddsChanged(string value)
        { update(); }
            
        partial void OnSizeChanged(string value) 
        { update(); }

        //uwaga wytlumaczenie kodu powyzej dla debili (dla mnie, nie dla pana pan jest mądry tylko moje białoruskie metody mogą doprowadzić do płaczu, wiem)
        //kazdy radiobutton w xamlu ma przypisany binding do zmiennej bool, jak ta zmienna sie zmieni to są te funkcje On{zmiennaboolean}Changed
        //teraz kiedy on widzi ze cos sie zmienilo ma parametr ktory mowi na co sie zmienilo. Teraz w srodku ma ifa ktory mowi czy sie zmienilo na true (czyli kliknelismy nowy radio)
        //to sprawdzanie jest ogolnie calkiem wazne bo jak sie odklikuje inny radio to tez aktywuje funkcje no bo zbindowana zmienna bool tez sie zmieni
        //no wiec sprawdzamy czy sie zmienil na true, jesli tak no to program wie ze to nowe klikniete radio. jesli przejdzie dalej i wie ze to nowe to jako wewnetrzna uzywaną 
        //przez nas w obliczeniach zmienna convertfrom i convertto ustawia jak trzeba
        //ale dajemy jeszcze zabezpieczenia wiec sprawdza czy na przyklad jak kliknelismy w from "d" to czy w to tez nie bylo "d", jesli tak to swapuje na ostatni wybrany from
        //i tutaj ma funkcje swapto (czli nie "zmień do" tylko zmien w grupie "to") i analogicznie ze swapfrom
        //i teraz tak, jezeli on wykryje w OnBooleanChanged ze trzeba swapowac to przykladowo na swapto dostaje parametr d to funkcja wszystkie ustawia na false oprocz decimal
        //bo ten byl w parametrze podany
        //update: po drodze sie skapnalem ze mi sie wykonuje nieskonczona petla podczas swapowania no bo zmieniamy te boole, a to znowu uruchamia funkcje onchanged
        //wiec są dodane flagi ze jak zamienia to onchanged sie uruchomi, ale ten jego wewnetrzny if nie przepusci dalszego kodu
        //kolejny update: dodalem wywolywanie updatu przy kazdej zmianie entry

        //przepraszam za taki GÓWNIANY kod do obslugi tych zdarzen ale robilem go w taki sposb zeby samemu wiedziec co sie dzieje, pozdrowionka



        //DOPIERO PONIZEJ MAMY OBSLUGE I LICZENIE TEGO WSZYSTKIEGO BOZEE ZABIJE SIE




        public void update()
        {
            //nwd
            static long gcd(long a, long b)
            {
                if (a == 0) return b;
                if (b == 0) return a;
                return a < b ? gcd(a, b % a) : gcd(b, a % b);
            }

            // decimal to fraction z jakiejs stronki, nie mam sily ogarniac matmy przepraszam 
            //https://www.geeksforgeeks.org/dsa/convert-given-decimal-number-into-an-irreducible-fraction/

            static string decimalToFraction(double number)
            {
                double intVal = Math.Floor(number);
                double fVal = number - intVal;
                long pVal = 1000000000;
                long gcdVal = gcd((long)Math.Round(fVal * pVal), pVal);
                long num = (long)Math.Round(fVal * pVal) / gcdVal;
                long deno = pVal / gcdVal;
                return ((long)(intVal * deno) + num) + "/" + deno;
            }


            //decimal
            if (convertFrom == "d")
            {
                //walidacja danych dla decimal i od razu przypisujemy je do zmiennych lokalnych zeby za kazdym razem nie parsować do doubla
                if (!double.TryParse(Odds, out double odds) || !double.TryParse(Size, out double size))
                {
                    Convertedodds = "-";
                    Payout = "-";
                    Win = "-";
                    return;
                }

                Win = (size * (odds - 1)).ToString();
                Payout = (size * odds).ToString();

                // d to f
                if (convertTo == "f")
                {
                    Convertedodds = decimalToFraction(odds - 1);
                }

                // d to a
                if (convertTo == "a")
                {
                    double profitRatio = odds - 1;

                    if (profitRatio <= 0)
                    {
                        Convertedodds = "0";
                    }
                    else if (odds >= 2.0)
                    {
                        int americanOdds = (int)Math.Round(profitRatio * 100);
                        Convertedodds = $"+{americanOdds}";
                    }
                    else
                    {
                        double americanOdds = -100.0 / profitRatio;
                        int rounded = (int)Math.Round(americanOdds);
                        Convertedodds = rounded.ToString();
                    }
                }

                // d to s
                if (convertTo == "s")
                {
                    double shares = (1.0 / odds) * 100.0;
                    Convertedodds = shares.ToString("0.#") + " ¢";
                }
            }


            //fraction
            if (convertFrom == "f")
            {
                // walidacja ulamkow dla fractions i size jako liczby
                string[] fractionParts = Odds?.Split('/');
                if (fractionParts == null || fractionParts.Length != 2 ||
                    !double.TryParse(fractionParts[0], out double numerator) ||
                    !double.TryParse(fractionParts[1], out double denominator) ||
                    denominator == 0 ||
                    !double.TryParse(Size, out double size))
                {
                    Convertedodds = "-";
                    Payout = "-";
                    Win = "-";
                    return;
                }


                // f to d
                if (convertTo == "d")
                {
                    double decimalOdds = numerator / denominator + 1.0;
                    Convertedodds = decimalOdds.ToString("0.00");
                    Win = (size * (decimalOdds - 1)).ToString();
                    Payout = (size * decimalOdds).ToString();
                }

                // f to a
                if (convertTo == "a")
                {
                    double profit = numerator / denominator;
                    double decimalOdds = profit + 1.0;

                    if (profit >= 1.0)
                    {
                        double american = profit * 100.0;
                        Convertedodds = "+" + american.ToString("0.#");
                    }
                    else if (profit > 0)
                    {
                        double american = -100.0 / profit;
                        Convertedodds = american.ToString("0.#");
                    }
                    else
                    {
                        Convertedodds = "0";
                    }

                    Win = (size * profit).ToString();
                    Payout = (size * decimalOdds).ToString();
                }

                // f to s
                if (convertTo == "s")
                {
                    double decimalOdds = numerator / denominator + 1.0;
                    double shares = (1.0 / decimalOdds) * 100.0;
                    Convertedodds = shares.ToString("0.#") + " ¢";

                    double profit = numerator / denominator;
                    Win = (size * profit).ToString();
                    Payout = (size * decimalOdds).ToString();
                }
            }

            //american
            if (convertFrom == "a")
            {
                // walidacja tu zwykla, byle by byly normalne liczby i fajrancil tyle ze trzeba rozrozniac plus i minus, ale zwykly int sobie z tym radzi
                if (!int.TryParse(Odds, out int americanOdds) || americanOdds == 0 || !double.TryParse(Size, out double size))
                {
                    Convertedodds = "-";
                    Payout = "-";
                    Win = "-";
                    return;
                }
                                
                double profitRatio, decimalOdds;
                if (americanOdds > 0)
                {
                    profitRatio = americanOdds / 100.0;
                    decimalOdds = 1.0 + profitRatio;
                }
                else
                {
                    profitRatio = 100.0 / (-americanOdds);
                    decimalOdds = 1.0 + profitRatio;
                }

                Win = (size * profitRatio).ToString();
                Payout = (size * decimalOdds).ToString();

                // a to d
                if (convertTo == "d")
                {
                    Convertedodds = decimalOdds.ToString("0.00");
                }

                // a to f
                if (convertTo == "f")
                {
                    Convertedodds = decimalToFraction(profitRatio);
                }

                // a to s
                if (convertTo == "s")
                {
                    double shares = (1.0 / decimalOdds) * 100.0;
                    Convertedodds = shares.ToString("0.#") + " ¢";
                }
            }

            //shares
            if (convertFrom == "s")
            {
                // walidacja
                if (string.IsNullOrEmpty(Odds))
                {
                    Convertedodds = "-";
                    Payout = "-";
                    Win = "-";
                    return;
                }

                double sharesValue;

                string oddsText = Odds.Trim();
                if (!double.TryParse(oddsText, out sharesValue))
                {
                    //jesli ktos wpadnie na genialny pomysl wstawiac tu ten znaczek to jest to idiotoodporne w teorii
                    string[] parts = oddsText.Split('¢');
                    if (parts.Length > 0 && double.TryParse(parts[0].Trim(), out sharesValue))
                    {
                        // dziala to nic nie trzeba robic, ale nie chce mi sie odwracac wszystkiego w ifie, wiec jest pusty blok z tym debilnym komentarzem ktory wlasnie pisze
                    }
                    else
                    {
                        Convertedodds = "-";
                        Payout = "-";
                        Win = "-";
                        return;
                    }
                }

                //jeszcze size
                if (sharesValue <= 0 || !double.TryParse(Size, out double size))
                {
                    Convertedodds = "-";
                    Payout = "-";
                    Win = "-";
                    return;
                }

                double decimalOdds = 100.0 / sharesValue;
                double profit = decimalOdds - 1.0;

                Win = (size * profit).ToString();
                Payout = (size * decimalOdds).ToString();

                // s to d
                if (convertTo == "d")
                {
                    Convertedodds = decimalOdds.ToString("0.00");
                }

                // s to f
                if (convertTo == "f")
                {
                    Convertedodds = decimalToFraction(profit);
                }

                // s to a
                if (convertTo == "a")
                {
                    if (profit >= 1.0)
                    {
                        double american = profit * 100.0;
                        Convertedodds = "+" + american.ToString("0.#");
                    }
                    else if (profit > 0)
                    {
                        double american = -100.0 / profit;
                        Convertedodds = american.ToString("0.#");
                    }
                    else
                    {
                        Convertedodds = "0";
                    }
                }
            }
        }
    }
}
