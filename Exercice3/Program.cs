// demander à l'utilisateur le rayon du cercle
Console.WriteLine("Rayon ?");
// récupérer le rayon du cercle
double Rayon = double.Parse(Console.ReadLine());
// calculer le périmètre
double Perimetre = 2 * Rayon * Math.PI;
// affchier le résultat
Console.WriteLine($"Le cercle de rayon {Rayon} a un périmètre égal à {Perimetre}");