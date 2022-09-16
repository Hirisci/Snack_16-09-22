//Console.WriteLine("Snack 1");
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


//Console.WriteLine("Snack 3");
//// somma di 10 input utente
//Console.WriteLine();

//int somma = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("Inserisci un numero: ");
//    somma += Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine($"La somma dei numeri inseriti é: {somma}");


//Console.WriteLine("Snack 4");
//// somma e media da 2 a 10
//Console.WriteLine();

//int somma = 0;
//int numeri= 0
//for (int i = 2; i <= 10; i++)
//{
//    somma+= i;
//    numeri++;
//}
//Console.WriteLine($"La somma dei numeri da 2 a 10 é {somma}");
//Console.WriteLine($"La somma dei numeri da 2 a 10 é {somma/numeri}");


//Console.WriteLine("Snack 5");
//// Pari o Successivo
//Console.WriteLine();

//Console.Write("Inserisci Primo numero: ");
//int numA = Convert.ToInt32(Console.ReadLine());
//if (numA% 2 == 0)
//{
//    Console.WriteLine(numA);
//}
//else
//{
//    Console.WriteLine(++numA);
//};


//Console.WriteLine("Snack 6");
//// Grande Gasby
//Console.WriteLine();

//Console.WriteLine("Nome");
//string nome= Console.ReadLine();
//string[] array = { "franco", "angelo", "michele" };
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] == nome.ToLower())
//    {
//        Console.WriteLine($"{nome} - sei in lista ");
//    }
//}

//Console.WriteLine("Snack 7");
//// Array di dispari
//Console.WriteLine();

//int[] ints = new int[6];
//for (int i = 0; i < ints.Length; i++)
//{
//    Console.Write("Inserisci numero Intero ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num % 2 == 1)
//    {
//        ints[i] = num;
//    }
//}


//Console.WriteLine("Snack 8");
//// somma numeri dispari
//Console.WriteLine();

int somma = 0;
int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (int i in ints)
{
    if (i % 2 == 1)
    {
        somma += i;
    }
}
Console.WriteLine(somma);