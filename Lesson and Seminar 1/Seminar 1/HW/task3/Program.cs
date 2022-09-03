// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Prompt(string message)
{
    Console.Write(message);                    // вывод приглашения
    string strValue;                           // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";      // вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);           // преобразование строки в целое число 
    return value;
}

int value = Prompt("Введите первое число > ");
int result;

if (value < 0)
{
    result = -value;
}
else
{
    result = value;
}

for (int index = 2; index <= result; index = index+2)
{
    System.Console.Write($" {index}, ");
}   