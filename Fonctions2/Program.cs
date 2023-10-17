// fonction
// rôle : calculer la somme de deux nombres entier
// retourne : la somme int
// nom : Somme
// paramètres : les deux nombres dont on souhaite connaître la somme
int Somme(int nombre1, int nombre2)
{
    return nombre1 + nombre2;
}
int N1 = 12;
int N2 = 4;
int ResultatSomme = Somme(N1, N2);
Console.WriteLine($"La somme de {N1} et {N2} est égale à {ResultatSomme}");

N1 = 124;
N2 = -43;
ResultatSomme = Somme(N1, N2);
Console.WriteLine($"La somme de {N1} et {N2} est égale à {ResultatSomme}");