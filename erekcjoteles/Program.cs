var start = 2;
var n = 100;

var a= new bool[n+1];
for (var i = 2; i < a.Length; i++)
{
    a[i] = true;
}

var pierwiastek = Math.Sqrt(n);

for (var i = 2; i <= n; i++)
{
    if (a[i])
    {
        for (var j=2; j<=n; j += i)
        {
            a[j] = false;
        }
    }
}

var lista = new List<int>();

for (var i = 2; i <= n; i++)
{
    if (a[i]) {
        lista.Add(i); 
    } 
}

Console.WriteLine($"Liczby pierwsze od {start} do {n}: {String.Join(", ",lista)}");

