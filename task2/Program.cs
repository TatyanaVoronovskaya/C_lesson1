﻿
// апишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();
Console.WriteLine("Введиту число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число {number}");
if (number%2 == 0) 
{
    Console.WriteLine($"{number} - число четное");
}
else
{
    Console.WriteLine($"{number} - число нечетное");
}