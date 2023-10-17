// création de la fonction
// fontion
// rôle : connaître la mention correspondant à une note
// nom : Mention
// retourne : une mention (string)
// paramètres : la note (int) dont on souhaite connaître la mention
string Mention(int note)
{
    if (note < 0 || note > 20)
    {
        return "Erreur : la note doit être entre 0 et 20";
    }
    if (note >= 16)
	{
		return "Très bien"; 
	}
	else if (note >= 14)
    {
        return "Bien";
    }
    else if (note >= 12)
    {
        return "Assez bien";
    }
    else if (note >= 10)
    {
        return "Passable";
    }
    else
    {
        return "Echec";
    }
}



// test de la fonction

int note = -114;
Console.WriteLine(Mention(note));