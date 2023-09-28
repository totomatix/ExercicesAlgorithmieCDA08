// Algorithme qui demande un nombre à l'utilisateur et qui lui affiche le cube de ce nombre

// Demander un nombre à l'utilisateur
Console.WriteLine("Renrez un nombre : ");

// Récupération du nombre de l'utilisateur
int Nombre = int.Parse(Console.ReadLine());

// Calcul du cube du nombre de l'utilisateur
int Cube = Nombre * Nombre * Nombre;

// Affichage du cube
Console.WriteLine($"Le cube de {Nombre} est égal à {Cube}");