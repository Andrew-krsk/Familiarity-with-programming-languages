// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int Prompt(string message)
{
    Console.Write(message);                    // вывод приглашения
    string strValue;                           // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";      // вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);           // преобразование строки в целое число 
    return value;
}

int value = Prompt("Введите первое число > ");

if (value %2 == 0)
{
    System.Console.WriteLine($"-> да");
}
else
{
    System.Console.WriteLine($"-> нет");
}