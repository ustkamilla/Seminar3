/*Задача 2

Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputInt("Введите координату x первой точки");
int y1 = InputInt("Введите координату y первой точки");
int z1 = InputInt("Введите координату z первой точки");

int x2 = InputInt("Введите координату x второй точки");
int y2 = InputInt("Введите координату y второй точки");
int z2 = InputInt("Введите координату z второй точки");

 double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double a;
    double b;
    double c;
    a = x2 - x1;
    b = y2 - y1;
    c = z2 - z1;
    double result = Math.Sqrt(a*a + b*b + c*c);
    return Math.Round(result, 2);
}

System.Console.WriteLine(Distance(x1, x2, y1, y2, z1, z2));