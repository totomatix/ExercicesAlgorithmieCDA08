// demander un caractère à l'utilisateur
Console.WriteLine("Rentrez un caractère (o,O pour affirmatif; n,N pour négatif)");
// récupérer le caractère
char Caractere = char.Parse(Console.ReadLine());
// Caractere = Console.ReadKey().KeyChar; autre possibilité

// si 'o' ou 'O' => affirmatif
if (Caractere == 'o' || Caractere == 'O')
{
    Console.WriteLine("Affirmatif");
}
// sinon si 'n' ou 'N' => négatif
else if (Caractere == 'n' || Caractere == 'N')
{
    Console.WriteLine("Négatif");
}
// dans tous les autre cas => ????
else
{
    Console.WriteLine("???");
}