// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.Clear();
Console.Write("Type a x-coordinate of point A: ");
double xa = double.Parse(Console.ReadLine()!);
Console.Write("Type a y-coordinate of point A: ");
double ya = double.Parse(Console.ReadLine()!);
Console.Write("Type a z-coordinate of point A: ");
double za = double.Parse(Console.ReadLine()!);

Console.Write("Type a x-coordinate of point B: ");
double xb = double.Parse(Console.ReadLine()!);
Console.Write("Type a y-coordinate of point B: ");
double yb = double.Parse(Console.ReadLine()!);
Console.Write("Type a z-coordinate of point B: ");
double zb = double.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(xa-xb,2) + Math.Pow(ya-yb,2) + Math.Pow(za-zb,2));
Console.Write($"Distance between 2 point is {distance:f2}");