Console.Write("N : ");
int N = int.Parse(Console.ReadLine());

int Somme = 0;

for (int i = 1; i <= N; i++)
{
    Somme += i;
}
Console.WriteLine($"Somme des {N} premiers entiers = {Somme}");
