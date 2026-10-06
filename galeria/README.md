# Task 18 - Galeria zdjęć
Prosta aplikacja mobilna pozwalająca na wyświetlanie wybranych zdjęć, wraz z informacjami o nich.

![Wygląd aplikacji](.github/assets/main-screen.jpg)

## Wymagania
Twoja aplikacja powinna spełniać następujące kryteria:
 - aplikacja powinna korzystać z obrazków umieszczonych w jej zasobach - `Resources`,
 - do każdego zdjęcia dołączony jest jego opis, tytuł oraz lokalizacja - znajdziesz te dane w pliku `pictures.json`,
 - aplikacja powinna umożliwiać lajkowanie zdjęć, lajki nie są permanentne - przy każdym uruchomieniu aplikacji ich liczba wynosi `0`,
 - usuwanie lajków odbywa się przez wciśnięcie przycisku `Usuń` - dekrementacja, nie zerowanie,
 - po wciśnięciu przycisku `Lokalizacja` powinien wyświetlać się komunikat, który wskaże lokalizację miejsca ze zdjęcia,
 - przewijanie zdjęć powinno odbywać się poprzez przyciski umieszczone przy dolnej krawędzi aplikacji,
 - po dojściu do ostatniego zdjęcia, jako następne powinno być wyświetlane pierwsze zdjęcie - zdjęcia możemy oglądać w pętli.

**W tym zadaniu nie masz swobody w implementacji interfejsu graficznego aplikacji**, musi on być maksymalnie podobny do interfejsu widocznego na poglądowym zdjęciu. Wszystkie wykorzystane kolory pochodzą z domyślnie generowanego pliku `Colors.xaml`.

**Pliki potrzebne do wykonania zadania** znajdziesz w katalogu `assets/` w tym repozytorium.

## Wskazówki

Poniżej znajdziesz wskazówki, które pomogą Ci się uporać z niektórymi problemami na które napotkasz podczas realizacji projektu.

### Wczytywanie pliku JSON
Plik JSON najlepiej umieścić w katalogu `Resources/raw`. Tam znajdziesz plik `AboutAssets.txt`, którego **nie usuwaj**. Otwórz plik, który się tam znajduje a zobaczysz wskazówki co do wczytywania tego typu zasobów.

Po wczytaniu pliku json jako zwykły tekst, możesz wykonać jego `deserializację` do wcześniej przygotowanej klasy (*model*):

```csharp
_pictureInfos = JsonSerializer.Deserialize<List<PictureInfo>>(contents)!;
```

### Klasa do obsługi pliku JSON
Aby możliwa była deserializacja pliku JSON, będziesz potrzebował do tego klasy, która odpowiada strukturze obiektów znajdujących się w pliku:

```csharp
public class PictureInfo
{
    [JsonPropertyName("index")]
    public int Index { get; set; }
    
    // Pozostałe właściwości (i być może metody?)
    // [...]
}
```

Dobrą praktyką jest używanie atrybutu `JsonPropertyNameAttribute` w celu precyzyjnego zmapowania właściwości w obiekcie JSON do właściwości w obiekcie C#. Dzięki temu aplikacja będzie odporna na zmiany wewnątrz platformy .NET.

**Miej na uwadze, że** klasa może mieś więcej właściwości, niż ich liczba w samej strukturze obiektu JSON.

### Serwis do obsługi zdjęć
Aby aplikacja była elegancka, dobrze będzie stworzyć oddzielny serwis do zarządzania informacjami o obrazkach, aby zwolnić z tej odpowiedzialności ViewModel. Taki serwis może być singletonem:

```csharp
public class PictureInfoService
{
    // Lista zdjęć
    private List<PictureInfo> _pictureInfos;

    public PictureInfoService()
    {
        // Tutaj możemy umieścić wywołanie InitializeAsync(), ale musimy zaczekać na jej zakończenie
        // [...]
    }

    private async Task InitializeAsync()
    {
        // Wczytywanie pliku JSON oraz jego deserializacja
        // [...]
    }

    public PictureInfo GetPictureInfo(int index)
    {
        // Pobieranie zdjęcia o zadanym indexsie
        // [...]
    }

    public int Count
    {
        // Pobieranie liczby wszystkich zdjęć
        // [...]
    }
}
```

**Zauważ, że** wczytanie pliku JSON musi odbyć się **asynchronicznie** - MAUI w przeciwieństwie do innych frameworków platformy .NET nie pozwala na asynchroniczną inicjalizację aplikacji, w związku z tym musimy wywołać funkcję asynchroniczną synchronicznie - poczekać na jej zakończenie. Na tym etapie nauki doskonale wiesz, w jaki sposób to zrobić, jeżeli nie - warto odświeżyć sobie wiedzę z IV klasy.

## Kryteria oceny

Aby uzyskać **radosnego plusa**, aplikacja musi spełniać wszystkie założenia opisane na początku oraz maksymalnie przypominać wygląd z obrazka umieszczonego na początku instrukcji.