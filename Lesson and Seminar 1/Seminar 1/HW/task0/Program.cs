// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Prompt(string message)
{
    Console.Write(message);                    // вывод приглашения
    string strValue;                           // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";      // вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);           // преобразование строки в целое число 
    return value;
}

int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");

if(firstValue > secondValue)
{
    System.Console.WriteLine($"max = {firstValue}");
}
else
{
    System.Console.WriteLine($"max = {secondValue}");
}