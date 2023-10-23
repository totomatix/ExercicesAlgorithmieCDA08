// fonction
// rôle : déterminer si un nombre donné en paramètre est premier ou pas
// retourne : vrai ou faux (booléen)
// nom : EstPremier
// paramètre : nombre entier (int)
bool EstPremier(int nombre)
{
    // boucle de 2 à racine de nombre
    for (int i = 2; i <= Math.Sqrt(nombre); i++)
    {
        // si i divise nombre => return false
        // si nombre modulo i égale 0 => return false
        if (nombre%i==0)
        {
            return false;
        }
    }
    // quand la boucle est terminée => return true
    return true;
}

Console.WriteLine(EstPremier(51));
Console.WriteLine(EstPremier(17));