﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Write("Введите число 1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber * secondNumber)
    Console.WriteLine($"Число {firstNumber} является квадратом числа {secondNumber}");
 else
    Console.WriteLine($"Число {firstNumber} не является квадратом числа {secondNumber}");
