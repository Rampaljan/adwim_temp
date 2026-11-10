using System;
using System.Collections.Generic;
using System.Text;

namespace plecak
{
    public class Przedmiot
    {
        public string nazwa;
        public double cena;
        public double waga;
        public double wartosc;

        public Przedmiot (string Nazwa, double Cena, double Waga, double Wartosc)
        {
            nazwa = Nazwa;
            cena = Cena;
            waga = Waga;
            wartosc = Wartosc;
        }
    }
}
