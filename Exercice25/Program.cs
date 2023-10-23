//Lire la suite des prix (en euros entiers et terminée par zéro) des achats d'un client. Calculer la somme qu'il doit, lire la somme qu'il paye, et simuler la remise de la monnaie en affichant les textes "10 Euros", "5 Euros" et "1 Euro" autant de fois qu'il y a de coupures de chaque sorte à rendre.

Console.WriteLine("Rentrez des prix d'articles un par un et rentrez 0 quand vous avez terminé.");
int Prix;
int Somme = 0;
do
{
    Prix = int.Parse(Console.ReadLine());
    Somme += Prix;
} while (Prix != 0);

Console.WriteLine($"Vous nous devez {Somme} euros.");
int ArgentClient;
do
{
    Console.WriteLine($"Combien donnez vous ? (doit être supérieur égal à {Somme}).");
    ArgentClient = int.Parse(Console.ReadLine());
} while (ArgentClient < Somme);

Console.WriteLine($"Vous avez donné {ArgentClient}.");
int ArgentARendre = ArgentClient - Somme;
Console.WriteLine($"Nous vous devons {ArgentARendre}");

#region Version avec While
//while (ArgentARendre >= 10)
//{
//    Console.WriteLine("10 euros.");
//    ArgentARendre -= 10;
//}
#endregion

#region Version utilisant la division entière

for (int i = 1; i <= ArgentARendre/10 ; i++)
{
    Console.WriteLine("10 euros.");
}
ArgentARendre %= 10;
#endregion

if (ArgentARendre >= 5)
{
    Console.WriteLine("5 euros.");
    ArgentARendre -= 5;
}

for (int i = 1; i <= ArgentARendre; i++)
{
    Console.WriteLine("1 euros.");
}


