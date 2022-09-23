// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();
Console.Write("Type a number of 5-digitals: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 100000 && number > 9999)
{
    string numberStr = number.ToString();
    if (numberStr [0] == numberStr [4] && numberStr [1] == numberStr[3])
    Console.Write("This number is palindrome");
    else
    Console.Write("This number is not palindrome");
}
else
{
    Console.WriteLine("Not 5-digital number. Type again");
}