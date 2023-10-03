// récupération du 1er réel
Console.WriteLine("Réel 1 :");
decimal N1 = decimal.Parse(Console.ReadLine());

// récupération du 2eme réel
Console.WriteLine("Réel 2 :");
decimal N2 = decimal.Parse(Console.ReadLine());

if (N1 > N2)
{
    Console.WriteLine($"Le nombre le plus grand est : {N1}");
}
else
{
    Console.WriteLine($"Le nombre le plus grand est : {N2}");
}