Console.WriteLine("Rentrez un nombre : ");
int Nombre = int.Parse(Console.ReadLine());

int Factorielle = 1;

for (int i = 2; i <= Nombre ; i++)
{
    Factorielle *= i;
}

Console.WriteLine($"La factorielle de {Nombre} est égale à {Factorielle}");