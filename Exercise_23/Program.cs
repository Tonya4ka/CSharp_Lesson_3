// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.Clear();
Console.Write("Type a number: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= number)
{
    Console.Write(Math.Pow(count,3));
    if (count != number)
       Console.Write(", ");
    count++;
}