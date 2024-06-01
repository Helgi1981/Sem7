// Задание 1. Совместная работа

// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

// Указание:
// Использовать рекурсию.

// Пример:
// 123 => 6
// 63 => 9

void PrintNaturalNumbers(int num)
{
    if (num == 0) return;
    PrintNaturalNumbers(num - 1); // Если поменять местами эти строки, на консоль
    Console.Write($"{num} "); // будут выведены значения в обратном порядке (классическая и хвостовая рекурсии)
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(number);