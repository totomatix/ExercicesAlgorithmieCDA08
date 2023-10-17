//Ecrire une procédure pour dire bonjour à une personne.
//Le nom de la personne sera passé en paramètre.
//L'affichage se fera à la console.

void DireBonjour(string nom)
{
    Console.WriteLine("Bonjour " + nom);
}

DireBonjour("Toto");

DireBonjour("Jacques");

string Nom = "Georges";
DireBonjour(Nom);