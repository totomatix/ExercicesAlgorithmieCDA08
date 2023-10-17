// fonction
// rôle : calculer la distance entre 2 points
// retourne : distance (double)
// nom : Distance
// paramètres : x1, x2, y1, y2 (double)
double Distance(double x1, double y1, double x2, double y2)
{
    double DiffX = x1 - x2;
    double DiffY = y1 - y2;
    double DiffX2 = DiffX * DiffX;
    double DiffY2 = DiffY * DiffY;
    double Somme = DiffX2 + DiffY2;
    double Distance = Math.Sqrt(Somme);

    return Distance;

    //return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); // le calcul sur une seule ligne
}




// tester la fonction
double PointAx = 2.3;
double PointAy = -2.3;

double PointBx = 1;
double PointBy = -4;

Console.WriteLine(Distance(PointAx,PointAy,PointBx,PointBy));