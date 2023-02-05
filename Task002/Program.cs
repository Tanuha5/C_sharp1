// Задача №1. Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Введите число A: "); // Вывод строки в терминал
int numberA= Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32 // Получение значний из терминала

Console.Write("Введите число B: "); // Вывод строки в терминал
int numberB = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32 // Получение значний из терминала
 
 if (numberB * numberB == numberA)
 {
    System.Console.WriteLine("ДА");
 }
  else
  {
System.Console.WriteLine("НЕТ");
  }  
