﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if (99 < num && num < 1000) 
{
    int num1 = num % 10;
    Console.WriteLine($"Последняя цифра этого числа равна: {num1}");
}
else
{
    Console.WriteLine($"Такого числа не существует ");
}