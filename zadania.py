def zadanie_1():
    liczba1 = float(input("Podaj pierwszą liczbę: "))
    liczba2 = float(input("Podaj drugą liczbę: "))
    operacja = input("Wybierz operację (+, -, *, /): ")

    if operacja == '+':
        wynik = liczba1 + liczba2
    elif operacja == '-':
        wynik = liczba1 - liczba2
    elif operacja == '*':
        wynik = liczba1 * liczba2
    elif operacja == '/':
        if liczba2 != 0:
            wynik = liczba1 / liczba2
        else:
            print("Błąd: Dzielenie przez zero!")
            return
    else:
        print("Nieznana operacja.")
        return

    print(f"Wynik: {wynik}")

if __name__ == "__main__":
    zadanie_1()
