//Écrire un algorithme qui demande à l’utilisateur un numéro de mois (compris entre 1 et 12) jusqu’à ce que la réponse convienne.
int NumeroMois;
bool NombreOK = true;
do
{
    Console.WriteLine("Rentrez un numéro de mois : ");
    NumeroMois = int.Parse(Console.ReadLine());
    if (!(NumeroMois >= 1 && NumeroMois <= 12))
    {
        Console.Write("Erreur, le numéro de mois doit être compris entre 1 et 12 ");
        NombreOK = false;
    }
    else
    {
        NombreOK = true;
    }
} while (NombreOK == false); // condition : la négation de la condition que doit remplir le nombre pour que la boucle s'arrête

Console.WriteLine($"Le mois choisi a pour numéro {NumeroMois}.");

// !( A && B ) = !A || !B : formule de De Morgan
// donc on aurait pu écrire la condition suivante :
// while (Nombre < 1 || Nombre > 3);
