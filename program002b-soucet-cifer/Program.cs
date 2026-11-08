// Řídicí proměnná pro opakování programu
string again = "a";

while (again.ToLower() == "a")
{
    Console.WriteLine("***********************************");
    Console.WriteLine("********* Ciferný součet **********");
    Console.WriteLine("***********************************");
    Console.WriteLine("************* Cordy ***************");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    // 1. Bezpečné načtení celého čísla od uživatele
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

    // 2. Číslo změníme na text
    string text = number.ToString();

    // 3. Neutrální hodnoty: 0 pro sčítání, 1 pro násobení
    int sum = 0;
    int product = 1;

    Console.WriteLine();
    Console.WriteLine("Průběh rozkladu čísla na cifry (zleva doprava):");

    // 4. Procházíme text znak po znaku
    foreach (char c in text)
    {
        if (char.IsDigit(c))            // znaménko '-' přeskočíme
        {
            int digit = c - '0';        // znak '7' (kód 55) -> číslo 7 (55 - 48)      48 = kód znaku '0'
            sum = sum + digit;
            product = product * digit;

            Console.WriteLine($"Získána cifra: {digit}");
        }
    }

    // 5. Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo:  {number}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine($"Ciferný součin: {product}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // 6. Dotaz na opakování programu
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}