// Zeptáme se uživatele na první číslo
Console.WriteLine("Zadejte první hodnotu (first):");
string vstupFirst = Console.ReadLine();
int first = int.Parse(vstupFirst); // Převedeme text na číslo

// Zeptáme se na poslední číslo
Console.WriteLine("Zadejte poslední hodnotu (last):");
string vstupLast = Console.ReadLine();
int last = int.Parse(vstupLast);

// Zeptáme se na krok
Console.WriteLine("Zadejte krok (step):");
string vstupStep = Console.ReadLine();
int step = int.Parse(vstupStep);

Console.WriteLine("--- Výpis řady ---");

// Tady je smyčka (cyklus). 
// Začneme na čísle 'first'.
// Dokud je číslo menší nebo rovno 'last', pokračujeme.
// Po každém kole přičteme 'step'.
for (int i = first; i <= last; i = i + step)
{
    Console.WriteLine(i);
}