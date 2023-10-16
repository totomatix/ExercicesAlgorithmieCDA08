Random objRandom = new Random();

int NbATrouver = objRandom.Next(101);

int NombreUtilisateur;
int NbCoups = 0;
do
{
    Console.WriteLine("Rentrez un nombre : ");
    NombreUtilisateur = int.Parse(Console.ReadLine());
    NbCoups++;
    if (NombreUtilisateur > NbATrouver)
    {
        Console.WriteLine("Plus petit !");
    }
    else if (NombreUtilisateur < NbATrouver)
    {
        Console.WriteLine("Plus grand !");
    }

} while (NbATrouver != NombreUtilisateur);

Console.WriteLine($"Bravo ! Tu as trouvé le nombre en {NbCoups} coups.");
