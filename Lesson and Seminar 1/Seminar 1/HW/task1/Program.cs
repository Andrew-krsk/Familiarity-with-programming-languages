// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

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
int thirdValue = Prompt("Введите третье число > ");
int max = 0;

if (firstValue > secondValue)
{
    max = firstValue;
}
else 
{
    max = secondValue;
}
if (max > thirdValue)
{
    System.Console.WriteLine($" max = {max}");
}
else
{
    max = thirdValue;
    System.Console.WriteLine($" max = {max}");
}