# BM-ADWiM-Task009_CalculatorBMI
Twoim zadaniem jest przygotowanie aplikacji umożliwiającej obliczanie BMI użytkownika.

## Cel zadania
Celem ćwiczenia jest:
 - Zapoznania się z mechanizmem nawigacji przez Shell.
 - Zapoznanie się z wzorcem architektonicznym MVVM.
 - Zapoznanie się zachowaniami w .NET MAUI.
 - Korzystanie z zewnętrznych bibliotek.
 - Obsługa komend w MAUI.

## Zadanie
Przygotuj kalkulator BMI, stosując wzorzec MVVM, który:
 - Posiada dwie strony (strona z formularzem, strona z wynikami)
 - **Formularz**:
    - Pole `Entry` - waga (kg)
    - Pole `Entry` - wzrost (cm)
    - Oba pola powinny korzystać z `NumericOnlyBehavior` oraz uniemożliwiać wpisanie innej wartości niż liczba.
    - Przycisk `Oblicz` powinien być aktywny tylko, jeżeli oba pola są wypełnione poprawnie.
 - **Strona z wynikami**
    - Powinna wyświetlać BMI użytkownika oraz informacje czy wartość jest w normie, czy użytkownik ma nadwagę, niedowagę lub otyłość.
    - W przypadku BMI, które nie jest w normie, etykieta z informacją powinna przyjmować kolor:
        - czerwony jeśli otyłość,
        - pomarańczowy jeśli nadwaga lub niedowaga.
 - **Ogólne**:
    - Strony oraz ViewModele powinny być zarejestrowane przez DI.
    - Nawigacja w aplikacji powinna się odbywać przez Shell.
    - Aplikacja powinna wyglądać dobrze zarówno w trybie desktopowym (*Windows*) jak i mobilnym (*Android*).

### Na ocenę celującą
Dodaj zakładki na dole strony:
 - Kalkulator
 - Ustawienia
 
 Na stronie ustawień powinniśmy móc ustawić tryb aplikacji - jasny lub ciemny.