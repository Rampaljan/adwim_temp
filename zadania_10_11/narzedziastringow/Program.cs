var tekst = "jannn  kowalskiii";
Console.WriteLine(Narzedzia.LiczSamogloski(tekst));
Console.WriteLine(Narzedzia.UsunPowtorzenia(tekst));

public static class Narzedzia
{
    public static int LiczSamogloski(string lancuch)
    {
        if (lancuch == null || lancuch == "")
        {
            return 0;
        }
        else
        {
            var suma = 0;
            List<char> list = new List<char> { 'a', 'ą', 'e', 'ę', 'i', 'u', 'o', 'ó', 'y', 'A', 'Ą', 'E', 'Ę', 'I', 'O', 'U', 'Ó', 'Y' };

            for(var i = 0; i < list.Count; i++) //przechodzenie po kazdej literce w liście
            {
                for (var j = 0; j < lancuch.Length; j++) //dla kazdej literki w liscie, przechodzenie po kazdej literce ze slowa
                {
                    if(list[i].Equals( lancuch[j])) //czy literki są równe
                    {
                        suma++;
                    }
                }
            }
            return suma;
        }
    }

    public static string UsunPowtorzenia(string lancuch)
    {
        if (lancuch == null || lancuch == "")
        {
            return "";
        }
        else

        {
            
            int powtorzenia = int.MaxValue;

            while (powtorzenia > 0)
            {
                powtorzenia = 0;
                var noweslowo = "";

                for (var i = 0; i < lancuch.Length; i++)
                {
                    if (i + 1 < lancuch.Length) //sprawdzenie czy nie jestesmy na ostatnim
                    {
                        if (lancuch[i] == lancuch[i + 1])
                        {
                            i += 1;
                            powtorzenia++;
                        }
                    }

                    noweslowo += lancuch[i];

                }
                lancuch = noweslowo;

            }
            return lancuch;
        }
    }
}
