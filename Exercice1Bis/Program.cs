// See https://aka.ms/new-console-template for more information

// demande de la marque de la voiture
Console.WriteLine("Marque ?");
string Marque = Console.ReadLine();

// demande de la modèle de la voiture
Console.WriteLine("Modèle ?");
string Modele = Console.ReadLine();

// demande de l'année de la voiture
Console.WriteLine("Année ?");
int Annee = int.Parse(Console.ReadLine());

// demande de la marque de la voiture
Console.WriteLine("Prix ?");
decimal Prix = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Marque : {Marque}");
Console.WriteLine($"Modele : {Modele}");
Console.WriteLine($"Annee : {Annee}");
Console.WriteLine($"Prix : {Prix}");
