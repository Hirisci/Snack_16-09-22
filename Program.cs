// Snack 1
// Due int e trova il maggiore

Console.WriteLine("Snack 1");
Console.WriteLine();

Console.WriteLine("Inserisci due numeri:");
Console.Write("Inserisci Primo numero: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Inserisci Primo numero: ");
double numB = Convert.ToDouble(Console.ReadLine());

Console.Write($"Il numero maggiore é ");
Console.WriteLine(numA > numB ? numA : numB);

// Snack 2
// Parola piú lunga

Console.WriteLine("Snack 2");
Console.WriteLine();

Console.WriteLine("Inserisci due Parole:");
Console.Write("Inserisci Primo Parola: ");
string wordA = Console.ReadLine();
Console.Write("Inserisci Primo Parola: ");
string wordB = Console.ReadLine();

Console.Write($"La parola piú lunga è ");
Console.WriteLine(wordA.Length > wordB.Length ? wordA : wordB);

