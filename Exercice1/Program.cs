// affichage de la question pour demander le nom
Console.WriteLine("Quel est votre nom ? ");
// récupération du nom dans une nouvelle variable
string Nom = Console.ReadLine();

// affichage de la question pour demander le prénom
Console.WriteLine("Quel est votre prénom ? ");
// récupération du prénom dans une nouvelle variable
string Prenom = Console.ReadLine();

// affichage de la question pour demander le age
Console.WriteLine("Quel est votre age ? ");
// récupération du age dans une nouvelle variable
int Age = int.Parse(Console.ReadLine());

// affichage de Bonjour suivi de la valeur de la variable Nom
Console.WriteLine("Bonjour " + Prenom + " " + Nom + ", vous avez " + Age + " ans.");
Console.WriteLine($"Bonjour {Prenom} {Nom}, vous avez {Age} ans.");







