// demander les infos
Console.Write("Age : ");
int Age = int.Parse(Console.ReadLine());
Console.Write("Années permis : ");
int AnneesPermis = int.Parse(Console.ReadLine());
Console.Write("Nombre d'accidents : ");
int Accidents = int.Parse(Console.ReadLine());
Console.Write("Ancienneté : ");
int Anciennete = int.Parse(Console.ReadLine());

// au départ tous les conducteurs ont 4 points
int Points = 4;

// on enlève ensuite des points en fonction des différents critères
if (Age < 25)
{
    Points--;
}
if (AnneesPermis < 2)
{
    Points--;
}
Points -= Accidents; // Points = Points - Accidents
if (Anciennete < 5)
{
    Points--;
}

Console.Write("Votre contrat : ");
switch (Points)
{
    case 1:
        Console.WriteLine("Rouge");
        break;
    case 2:
        Console.WriteLine("Orange");
        break;
    case 3:
        Console.WriteLine("Vert");
        break;
    case 4:
        Console.WriteLine("Bleu");
        break;
    default:
        Console.WriteLine("Refusé");
        break;
}