//Ecrire et tester une fonction qui, à partir d'un nombre entier passé en paramètre, renvoie un booléen égal à true si le nombre est pair et false sinon.

// fonction
// rôle : indique si un nombre est pair ou impair
// retourne : un booleen (true : le nb est pair, false : impair)
// nom : EstPair
// paramètre(s) : un nombre entier (dont on souhaite savoir si il est pair)

bool EstPair(int nombre)
{
    return (nombre % 2 == 0);
}

Console.WriteLine("Rentrez un nombre entier :");
int Nombre = int.Parse(Console.ReadLine());
if (EstPair(Nombre))
{
    Console.WriteLine($"Le nombre {Nombre} est pair.");
}
else
{
    Console.WriteLine($"Le nombre {Nombre} est impair.");

}