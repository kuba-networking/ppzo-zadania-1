using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- ZADANIE 2: Konwerter temperatur ---");
        Console.Write("Wybierz kierunek (c - Celsjusz na Fahrenheit, f - Fahrenheit na Celsjusz): ");
        
        string inputKierunek = Console.ReadLine();
        char kierunek = ' ';
        if (!string.IsNullOrEmpty(inputKierunek))
        {
            kierunek = char.ToLower(inputKierunek[0]);
        }

        Console.Write("Podaj wartość temperatury: ");
        if (double.TryParse(Console.ReadLine(), out double temp))
        {
            if (kierunek == 'c')
            {
                double wynik = temp * 1.8 + 32;
                Console.WriteLine($"{temp}°C = {wynik}°F");
            }
            else if (kierunek == 'f')
            {
                double wynik = (temp - 32) / 1.8;
                Console.WriteLine($"{temp}°F = {wynik:F2}°C");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór kierunku konwersji.");
            }
        }
        else
        {
            Console.WriteLine("Błąd: Podano niepoprawną wartość temperatury!");
        }
    }
}
