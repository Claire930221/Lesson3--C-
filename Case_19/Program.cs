/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
var num = Console.ReadLine() ?? "";
int n = num.Length;

if (n == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - не палиндром");
    }
}
else
{
    Console.WriteLine($"{num} - не является пятизначным");
}
