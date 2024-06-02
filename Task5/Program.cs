// Задача 2:

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n. 

// Пример:
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        throw new ArgumentException("m и n должны быть целыми неотрицательными числами");
    }
}

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана A({m},{n}) = {Ackermann(m, n)}");


// Метод Ackermann производит вычисление функции Аккермана согласно следующим правилам:
// Если m равно 0, то результат равен n + 1.
// Если m больше 0 и n равно 0, то результат равен Ackermann(m - 1, 1).
// Если m больше 0 и n больше 0, то результат равен Ackermann(m - 1, Ackermann(m, n - 1)).
