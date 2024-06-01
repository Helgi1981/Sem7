// Задание 3. Совместная работа

// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

// Указание:
// Использовать рекурсию. Не использовать цикл.

// Пример:
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void CheckPrintConsonants(string str, int index)
{
    string vowels = "aeiouy";
    if (char.IsAsciiLetter(str[index]) && !vowels.Contains(str[index]))
    {
        Console.Write($"{str[index]}");
    }
}

void PrintConsonants(string str, int index = 0)
{
    if (index == str.Length)
    {
        return;
    }
    CheckPrintConsonants(str, index);
    PrintConsonants(str, index + 1);
}

Console.WriteLine("Введите строку из латинских букв: ");
string text = Console.ReadLine();
Console.WriteLine();
PrintConsonants(text);
