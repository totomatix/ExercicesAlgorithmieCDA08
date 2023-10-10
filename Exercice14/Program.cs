// la ligne suivante permet d'afficher le signe euro
Console.OutputEncoding = System.Text.Encoding.UTF8;

// déclaration des prix
const decimal Prix10Premieres = 0.1m;
const decimal Prix20Suivantes = 0.09m;
const decimal PrixPlusQue30 = 0.08m;


// récupération du nombre de photocopies souhaité par l'utilisateur
Console.WriteLine("Combien de photocopies ?");
int NbPhotocopies = int.Parse(Console.ReadLine());


// si entre 1 et 10 photocopies
if (NbPhotocopies <= 10)
{
    Console.WriteLine("Vous devez : " + NbPhotocopies * Prix10Premieres + "€");
}
// si entre 11 et 30 photocopies
else if (NbPhotocopies > 10 && NbPhotocopies <= 30)
{
    //Console.WriteLine("Vous devez : " + (1 + (NbPhotocopies - 10) * Prix20Suivantes));
    Console.WriteLine("Vous devez : " + (10*Prix10Premieres + (NbPhotocopies-10)*Prix20Suivantes) + "€");
}
// si plus que 30
else
{
    //Console.WriteLine("Vous devez : " + (2,8 + (NbPhotocopies - 30) * PrixPlusQue30));
    Console.WriteLine("Vous devez : " + (10 * Prix10Premieres + 20 * Prix20Suivantes + (NbPhotocopies - 30) * PrixPlusQue30) + "€");
}