using System;
using System.Collections.Generic;
using System.Text;

namespace plecak
{
    public class Kalkulator
    {
        List<Przedmiot> Przedmioty = new List<Przedmiot>();

        public void Czytajplik()
        {
            string Filename = "items.csv";

            foreach (var line in File.ReadAllLines(Filename).Skip(1))
            {
                var SplitLine = line.Split(';');
                string name = SplitLine[1];
                double waga = double.Parse(SplitLine[2]);
                double cena = double.Parse(SplitLine[3]);
                double wartosc = cena / waga;

                Przedmiot przedmiot = new Przedmiot(name, cena, waga, wartosc);
                Przedmioty.Add(przedmiot);
            }

            Przedmioty = Przedmioty.OrderByDescending(item => item.wartosc).ToList();
        }

        public void Wypelnij()
        {

            Plecak plecak = new Plecak();
            var flag = true;
            var najmniejsza = Przedmioty.MinBy(m => m.waga);

            //while (flag)
            //{
            //    for(var i = 0; i < )


            //    if ((12000 - plecak.LiczWage()) < najmniejsza.waga)
            //    {
            //        flag = false;
            //    }
            //}

            for (int i = 0; i < Przedmioty.Count; i++)
            {
                if ((Przedmioty[i].waga + plecak.LiczWage()) <= 12000)
                {
                    plecak.PrzedmiotyWrzucone.Add(Przedmioty[i]);

                }

            }

            Console.WriteLine(plecak.LiczWage());
            Console.WriteLine(plecak.LiczCene());

            foreach (var item in plecak.PrzedmiotyWrzucone)
            {
                Console.WriteLine(item.nazwa);
                Console.WriteLine(item.cena);
                Console.WriteLine(item.waga);
                Console.WriteLine("");
            }

        }


        //petla ktora bierze najwyzszy obiekt i sprawdza czy jego waga sie zmiesci w plecaku i go tam wpierdala
        //jesli sie nie miesci to leci do nastepnego obiektu i znowu

        


    }
}
