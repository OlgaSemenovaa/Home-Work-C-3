// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z3 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x, x1, y, y1, z, z1);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int a1, int a2, int b1, int b2, int c1, int c2);
{
    double dist = Math.Sqrt((a1 - a2)*(a1 - a2)+(b1 - b2)*(b1 - b2)+(c1 - c2)*(c1 - c2));
    return dist;
}
