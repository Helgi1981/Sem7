// Задача 1:

// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Примеры:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNaturalNumber()
{
    int number;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Введите натуральное число: ");
        }
    }
}

void PrintNaturalNumbers(int M, int N)
{
    if (M == N)
    {
        Console.Write($"{M}");
    }
    else
    {
        Console.Write($"{M}, ");
        if (M < N)
        {
            PrintNaturalNumbers(M + 1, N);
        }
        else
        {
            PrintNaturalNumbers(M - 1, N);
        }
    }
}

Console.WriteLine("Введите начальное значение M: ");
int M = ReadNaturalNumber();

Console.WriteLine("Введите конечное значение N: ");
int N = ReadNaturalNumber();

PrintNaturalNumbers(M, N);