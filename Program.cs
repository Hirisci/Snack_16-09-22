﻿//Console.WriteLine("Snack 1");
//// Due int e trova il maggiore
//Console.WriteLine();

//Console.WriteLine("Inserisci due numeri:");
//Console.Write("Inserisci Primo numero: ");
//double numA = Convert.ToDouble(Console.ReadLine());
//Console.Write("Inserisci Primo numero: ");
//double numB = Convert.ToDouble(Console.ReadLine());

//Console.Write($"Il numero maggiore é ");
//Console.WriteLine(numA > numB ? numA : numB);



//Console.WriteLine("Snack 2");
//// Parola piú lunga
//Console.WriteLine();

//Console.WriteLine("Inserisci due Parole:");
//Console.Write("Inserisci Primo Parola: ");
//string wordA = Console.ReadLine();
//Console.Write("Inserisci Primo Parola: ");
//string wordB = Console.ReadLine();

//Console.Write($"La parola piú lunga è ");
//Console.WriteLine(wordA.Length > wordB.Length ? wordA : wordB);


Console.WriteLine("Snack 3");
Console.WriteLine();

int somma = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("Inserisci un numero: ");
    somma += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"La somma dei numeri inseriti é: {somma}");
