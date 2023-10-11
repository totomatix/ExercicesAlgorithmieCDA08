//Écrire un algorithme qui demande à l'utilisateur d'entrer un nombre entier.
//Le programme affichera la table de multiplication de ce nombre, présentée comme suit.

//Exemple : Table de 7
//7 x 1 = 7
//7 x 2 = 14
//7 x 3 = 21
//...
//7 x 10 = 70

// Récupération du nombre de l'utilisateur
Console.WriteLine("Nombre : ");
int Nombre = int.Parse(Console.ReadLine());

// Affichage de la table de multiplication
Console.WriteLine($"Table de {Nombre} : ");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{Nombre}x{i}={Nombre * i}");
}