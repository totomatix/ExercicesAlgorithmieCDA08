// fonction
// rôle : pose la question passée en paramètre à l'utilisateur et retourne sa réponse qui doit être oui ou non
// retourne : la réponse de l'utilisateiout (oui/non) string
// nom : Reponse
// paramètre : la question qui sera posée à l'utilisateur
string Reponse(string question)
{
    // affichage de la question
    string ReponseUtilisateur;
    do
    {
        Console.WriteLine(question + " (oui/non)");
        ReponseUtilisateur = Console.ReadLine(); 
    } while (ReponseUtilisateur != "oui" && ReponseUtilisateur != "non");

    return ReponseUtilisateur;
}

// tests de la fonction
string Rep1 = Reponse("Es-tu marié ?");
Console.WriteLine("Votre réponse : " + Rep1);

string Rep2 = Reponse("As-tu des enfants ?");
Console.WriteLine("Votre réponse : " + Rep2);
