// récupération du 1er nombre
Console.WriteLine("Nombre 1 :");
int N1 = int.Parse(Console.ReadLine());

// récupération du 2eme nombre
Console.WriteLine("Nombre 2 :");
int N2 = int.Parse(Console.ReadLine());

if (N1 >= 0 && N2 >= 0 || N1 <= 0 && N2 <= 0)
{
    Console.WriteLine("Positif");
}
else
{
    Console.WriteLine("Négatif");
}
