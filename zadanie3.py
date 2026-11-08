def zadanie_3():
    liczba_ocen = int(input("Podaj liczbę ocen: "))
    suma = 0.0

    for i in range(liczba_ocen):
        ocena = float(input(f"Podaj ocenę {i+1}: "))
        suma += ocena

    srednia = suma / liczba_ocen
    print(f"Średnia: {srednia:.2f}")

    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")

if __name__ == "__main__":
    zadanie_3()
