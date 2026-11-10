using System;
using System.Collections.Generic;
using System.Text;

namespace plecak
{
    public class Plecak
    {
        public double Waga = 0;
        public double Cena = 0;

        public List<Przedmiot> PrzedmiotyWrzucone = new List<Przedmiot>();
            
        public double LiczWage()
        {
            double suma = 0;
            foreach (var item in PrzedmiotyWrzucone) 
            {
                suma += item.waga;
            }
            return suma;
        }

        public double LiczCene()
        {
            double suma = 0;
            foreach (var item in PrzedmiotyWrzucone)
            {
                suma += item.cena;
            }
            return suma;
        }

    }
}
