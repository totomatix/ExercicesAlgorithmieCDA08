Console.WriteLine("Rentrez une note entre 0 et 20 :");
int Note = int.Parse(Console.ReadLine());

if (Note >=10)
{
    Console.WriteLine("Admis");
}
else if (Note > 8)
{
    Console.WriteLine("Rattrapage");
}
else
{
    Console.WriteLine("Echec");
}
