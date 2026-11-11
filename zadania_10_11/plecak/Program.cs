using System;
using System.Collections.Generic;
using System.Text;

namespace plecak
{
    public class Program
    {
        public static void Main()
        {
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.Czytajplik();

            kalkulator.Wypelnij();


        }
    }
}
