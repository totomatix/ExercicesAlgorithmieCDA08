// demander à l'utilisateur un nombre
Console.WriteLine("Rentrez un nombre ?");
// récupérer le rayon du cercle
int Nombre = int.Parse(Console.ReadLine());
// si le nombre est pair (c.a.d si il est divisible par 2)
if (Nombre % 2 == 0)
{
    Console.WriteLine($"{Nombre} est pair");
}