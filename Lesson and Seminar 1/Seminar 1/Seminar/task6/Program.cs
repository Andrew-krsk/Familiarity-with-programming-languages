// Напишите программу вычисления модуля числа.
// 	2 -> 2
// 	-3 -> 3
// 	-7 -> 7

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

if(value < 0)
{
    result = -value;
}
else
{
    result = value;
}
System.Console.WriteLine($"{value} -> {result}");