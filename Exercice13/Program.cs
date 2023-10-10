char Sexe = 'H';

int Age = 40;

#region 1ere version
if (Sexe == 'H')
{
    // homme
    if (Age >= 20)
    {
        Console.WriteLine("Impots");
    }
    else
    {
        Console.WriteLine("Pas d'impots");
    }
}
else
{
    // femme
    if (Age >= 18 && Age <= 35)
    {
        Console.WriteLine("Impots");
    }
    else
    {
        Console.WriteLine("Pas d'impots");
    }
}
#endregion

#region 2eme version : une seul condition pour les cas qui paient l'impot
if ((Sexe == 'H' && Age >= 20) || (Sexe == 'F' && (Age >= 18 && Age <= 35)))
{
    Console.WriteLine("Impots");
}
else
{
    Console.WriteLine("Pas d'impots");
}
#endregion

#region 3eme version : une seul condition pour les cas qui ne paient pas l'impot
if ((Sexe == 'H' && Age < 20) || (Sexe == 'F' && (Age < 18 || Age > 35)))
{
    Console.WriteLine("Pas d'impots");
}
else
{
    Console.WriteLine("Impots");
} 
#endregion