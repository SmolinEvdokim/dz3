// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double x1 = Coordinate("x", "A");
double y1 = Coordinate("y", "A");
double z1 = Coordinate("z", "A");
double x2 = Coordinate("x", "B");
double y2 = Coordinate("y", "B");
double z2 = Coordinate("z", "B");

double Coordinate(string coorName, string pointName)
{
    Console.Write($"Koordinati {coorName} dlia {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"dlinna ravna:  {segmentLength}");


