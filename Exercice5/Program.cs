int A = 12;
int B = -5;

// affichage des 2 valeurs avant permutation
Console.WriteLine("Avant permutation :");
Console.WriteLine($"A : {A}");
Console.WriteLine($"B : {B}");

// permutation des valeurs des deux variables
int Tmp = A;
A = B;
B = Tmp;

// affichage des 2 valeurs après permutation
Console.WriteLine("Après permutation :");
Console.WriteLine($"A : {A}");
Console.WriteLine($"B : {B}");