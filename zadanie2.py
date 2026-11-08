def zadanie_2():
    print("--- ZADANIE 2: Konwerter temperatur ---")
    kierunek = input("Wybierz kierunek (c - Celsjusz na Fahrenheit, f - Fahrenheit na Celsjusz): ").lower()
    temp = float(input("Podaj wartość temperatury: "))

    if kierunek == 'c':
        wynik = temp * 1.8 + 32
        print(f"{temp}°C = {wynik:.0f}°F")
    elif kierunek == 'f':
        wynik = (temp - 32) / 1.8
        print(f"{temp}°F = {wynik:.2f}°C")
    else:
        print("Nieprawidłowy wybór kierunku konwersji.")

if __name__ == "__main__":
    zadanie_2()
  
