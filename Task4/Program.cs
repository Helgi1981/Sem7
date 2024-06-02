// Задача 1:

// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Примеры:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNaturalNumbers(int M, int N)
{
    if (M > N) return;
    Console.Write($"{M} ");
    PrintNaturalNumbers(M + 1, N);
}

Console.WriteLine("Введите начальное значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(M, N);


// 1. Метод PrintNaturalNumbers(int M, int N) принимает два аргумента:
// начальное значение M и конечное значение N.

// 2. Если значение M больше N, рекурсия прекращается.

// 3. В противном случае текущее значение M выводится на консоль,
// после чего вызывается рекурсивный метод PrintNaturalNumbers 
// с увеличеним значения M на 1.
