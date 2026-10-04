using System.Diagnostics;
using System;

namespace pesele_menele
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Entry entry = new Entry { Placeholder = "Enter text" };
        }

        private void Encodowanie(object? sender, EventArgs e)
        {
            var rok = entry_rok.Text;
            var msc = entry_miesiac.Text;
            var dzien = entry_dzien.Text;
            var plec = entry_plec.Text;

            //if 

            //TODO ENCODING



            //string millenium = $"{rok[0]}{rok[1]}";

            //switch 





            var wynik = rok + msc + dzien + plec;
            WynikEncodowania.Text = wynik;
            SemanticScreenReader.Announce(WynikEncodowania.Text);
        }

        private static bool Test_Kontrolny(string Pesel)
        {
            var i0 = Pesel[0] - '0';
            var i1 = Pesel[1] - '0';
            var i2 = Pesel[2] - '0';
            var i3 = Pesel[3] - '0';
            var i4 = Pesel[4] - '0';
            var i5 = Pesel[5] - '0';
            var i6 = Pesel[6] - '0';
            var i7 = Pesel[7] - '0';
            var i8 = Pesel[8] - '0';
            var i9 = Pesel[9] - '0';
            var kontrolna = Pesel[10] - '0';


            int wynik = 0;

            string liczba = "";
            int lntemp = 0;
            int dododania = 0;


            liczba = (i0 * 1).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i0 + " * 1 = " + liczba + " => " + dododania);


            liczba = (i1 * 3).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i1 + " * 3 = " + liczba + " => " + dododania);

            liczba = (i2 * 7).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i2 + " * 7 = " + liczba + " => " + dododania);

            liczba = (i3 * 9).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i3 + " * 9 = " + liczba + " => " + dododania);

            liczba = (i4 * 1).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i4 + " * 1 = " + liczba + " => " + dododania);

            liczba = (i5 * 3).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i5 + " * 3 = " + liczba + " => " + dododania);

            liczba = (i6 * 7).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i6 + " * 7 = " + liczba + " => " + dododania);

            liczba = (i7 * 9).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i7 + " * 9 = " + liczba + " => " + dododania);

            liczba = (i8 * 1).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i8 + " * 1 = " + liczba + " => " + dododania);

            liczba = (i9 * 3).ToString();
            lntemp = (liczba).Length;
            dododania = liczba[lntemp - 1] - '0';
            wynik += dododania;
            //Console.WriteLine(i9 + " * 3 = " + liczba + " => " + dododania);


            string doodjecia = $"{wynik}";

            int doodjecialn = doodjecia.Length;
            int finaldoodjecia = doodjecia[doodjecialn - 1] - '0';

            //Console.WriteLine("Wynik: " + doodjecia + " => " + finaldoodjecia);

            int ostateczny_wynik = 10 - finaldoodjecia;

            if (ostateczny_wynik == kontrolna)
            {
                //    Console.WriteLine("działa");
                return true;
            }
            else
            {
                //Console.WriteLine("nie działa");
                return false;
            }

        }


        private void Dekodowanie(object? sender, EventArgs e)
        {
            var wynik = "";
            string Pesel = entry.Text;

            if (Pesel != "" && Pesel != null)
                {
                    if (Pesel.Length == 11)
                    {
                        if (Test_Kontrolny(Pesel))
                        {
                            string koncowka = "";
                            string jejczymu = "";
                            string rr = $"{Pesel[0]}{Pesel[1]}";
                            string mm = $"{Pesel[2]}{Pesel[3]}";
                            string dd = $"{Pesel[4]}{Pesel[5]}";
                            string pppp = $"{Pesel[6]}{Pesel[7]}{Pesel[8]}{Pesel[9]}";
                            string k = $"{Pesel[10]}";

                            int plec = int.Parse($"{pppp[3]}");

                            string interpretacja_plci = "";

                            if (plec % 2 == 0)
                            {
                                interpretacja_plci = "Kobieta";
                                koncowka = "a";
                                jejczymu = "jej";
                            }
                            else
                            {
                                interpretacja_plci = "Mężczyzna";
                                koncowka = "y";
                                jejczymu = "mu";
                            }

                            var millenium = "";

                            var pierwsza_literka_miesiąca = $"{mm[0]}";
                            string miesiac = "";
                            var pierwszaliterkafinal = "";

                            switch (pierwsza_literka_miesiąca)
                            {
                                case "8":
                                    millenium = "18";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 8}";
                                    break;
                                case "9":
                                    millenium = "18";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 8}";
                                    break;
                                case "0":
                                    millenium = "19";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 0}";
                                    break;
                                case "1":
                                    millenium = "19";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 0}";
                                    break;
                                case "2":
                                    millenium = "20";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 2}";
                                    break;
                                case "3":
                                    millenium = "20";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 2}";
                                    break;
                                case "4":
                                    millenium = "21";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 4}";
                                    break;
                                case "5":
                                    millenium = "21";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 4}";
                                    break;
                                case "6":
                                    millenium = "22";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 6}";
                                    break;
                                case "7":
                                    millenium = "22";
                                    pierwszaliterkafinal = $"{(mm[0] - '0') - 6}";
                                    break;
                                default:
                                    break;
                            }

                            miesiac = $"{(pierwszaliterkafinal + mm[1])}";

                            DateTime Teraz = DateTime.Now.Date;

                            var UrodzinyStr = Teraz.Year + "/" + miesiac + "/" + dd;

                            DateTime Urodziny = DateTime.Parse(UrodzinyStr);

                            var ileDni = (Urodziny.Subtract(Teraz)).Days;


                            var UroFinal = dd + "." + miesiac + "." + millenium + rr;

                            wynik = "Osoba z peselem: " + Pesel + " to " + interpretacja_plci + ", urodzon" + koncowka + ": " + UroFinal + ", Do urodzin pozostało " + jejczymu + ": " + ileDni + " dni.";

                            //Dane sparsowane i gotowe do ewentualnego wysłania w jakimś arrayu:
                            //str Pesel = 12345678901
                            //str interpretacja plci = kobieta/mężczyzna
                            //str UroFinal = 02.04.2008
                            //int ileDni = 10

                            //ewentualne zaimki:
                            // jejczymu = "jej" / "mu"
                            // koncowka = "a" / "y"

                            //Cały sparsowany wynik:
                            //var wynik

                            

                        }
                        else
                        {
                        wynik = "Liczba Kontrolna się nie zgadza";
                        }
                    }
                    else
                    {
                        wynik = "Pesel ma 11 cyfr";
                    }
                }
                else
                {
                    wynik = "Nie wpisałeś nic";
                }

            CounterBtn2.Text = wynik;
            SemanticScreenReader.Announce(CounterBtn2.Text);
        }
    }   
}

