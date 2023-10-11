//Écrire un algorithme qui demande à l’utilisateur un nombre compris entre 1 et 3 jusqu’à ce que la réponse convienne.
int Nombre;
bool NombreOK = true;
do
{
	Console.WriteLine("Rentrez un nombre entre 1 et 3 : ");
	Nombre = int.Parse(Console.ReadLine());
    if (!(Nombre >= 1 && Nombre <= 3))
    {
        Console.Write("Erreur : ");
        NombreOK = false;
    }
    else
    {
        NombreOK = true;
    }
} while (NombreOK == false); // condition : la négation de la condition que doit remplir le nombre pour que la boucle s'arrête

Console.WriteLine($"Vous avez rentré le nombre {Nombre} qui est bien compris entre 1 et 3");

// !( A && B ) = !A || !B : formule de De Morgan
// donc on aurait pu écrire la condition suivante :
// while (Nombre < 1 || Nombre > 3);
