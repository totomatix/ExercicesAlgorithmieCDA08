Console.Write("N : ");
int N = int.Parse(Console.ReadLine());

int Somme = 0;

#region 1ere version
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0) // si i est pair => on effectue la somme
    {
        Somme += i;
    }
}
Console.WriteLine($"Version 1 : Somme des {N} premiers entiers pairs = {Somme}");
#endregion

Somme = 0;
#region 2eme version
for (int i = 2; i <=N; i+=2)
{
    Somme += i;
}
Console.WriteLine($"Version 2 : Somme des {N} premiers entiers pairs = {Somme}");
#endregion

