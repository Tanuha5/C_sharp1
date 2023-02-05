// Задача 6: Напишите программу, которая на вход принимает число 
// и выдает, является ли число четным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    System.Console.WriteLine("Четное");
}
else
{
    System.Console.WriteLine("Нечетное");
}

