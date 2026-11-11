var male = "qwertyuioplkjhgfdsazxcvbnm";
var duze = "QWERTYUIOPLKJHGFDSAZXCVBNM";
var polskie = "ążśźćęółńĄĘŁŚĆŹŻÓŃ";
var specjalne = "!@#$%^&*()_+";
var cyfry = "0123456789";

Console.WriteLine("Wygenerowane hasła: ");
for(var j =0; j<5; j++)
{
    List<char> haslo = new List<char>();
    var rnd = new Random();

    for (int i = 0; i < 3; i++)
    {
        haslo.Add(male[rnd.Next(0, male.Length)]);
    }

    for (int i = 0; i < 3; i++)
    {
        haslo.Add(duze[rnd.Next(0, duze.Length)]);
    }

    for (int i = 0; i < 2; i++)
    {
        haslo.Add(polskie[rnd.Next(0, polskie.Length)]);
    }

    for (int i = 0; i < 2; i++)
    {
        haslo.Add(specjalne[rnd.Next(0, specjalne.Length)]);
    }

    for (int i = 0; i < 2; i++)
    {
        haslo.Add(cyfry[rnd.Next(0, cyfry.Length)]);
    }

    var hasloText = String.Join("", haslo.Shuffle());
    Console.WriteLine(hasloText);

}



