// récupération du 1er réel
Console.WriteLine("Nombre entier :");
int Nombre = int.Parse(Console.ReadLine());

// affichage de : positif, négatif ou nul
if (Nombre == 0)
{
    Console.WriteLine($"Le nombre {Nombre} est nul.");
}
else if (Nombre < 0)
{
    Console.WriteLine($"Le nombre {Nombre} est négatif.");
}
else
{
    Console.WriteLine($"Le nombre {Nombre} est positif.");
}