/*
Задача 21

Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координаты точки А, x= ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А, y= ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А, z= ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B, x= ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B, y= ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B, z= ");
int zB = Convert.ToInt32(Console.ReadLine());

double s = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
s = Math.Round(s, 2);
Console.WriteLine("Растояние между точками A и B =" + s);