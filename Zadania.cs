using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = double.Parse(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        char operacja = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double wynik = 0;
        bool poprawnaOperacja = true;

        if (operacja == '+')
        {
            wynik = liczba1 + liczba2;
        }
        else if (operacja == '-')
        {
            wynik = liczba1 - liczba2;
        }
        else if (operacja == '*')
        {
            wynik = liczba1 * liczba2;
        }
        else if (operacja == '/')
        {
            if (liczba2 != 0)
            {
                wynik = liczba1 / liczba2;
            }
            else
            {
                Console.WriteLine("Błąd: Dzielenie przez zero!");
                poprawnaOperacja = false;
            }
        }
        else
        {
            Console.WriteLine("Nieznana operacja.");
            poprawnaOperacja = false;
        }

        if (poprawnaOperacja)
        {
            Console.WriteLine($"Wynik: {wynik}");
        }
    }
}
