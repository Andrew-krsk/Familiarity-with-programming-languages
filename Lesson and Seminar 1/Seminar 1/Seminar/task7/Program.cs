// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

double Prompt(string message)
{
    Console.Write(message);                    // вывод приглашения
    string strValue;                           // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";      // вводим строку с консоли (с консоли можно ввести только строку)
    double value = double.Parse(strValue);           // преобразование строки в целое число 
    return value;
}

double value = Prompt("Введите первое число > ");
if (value == 0)
{
    System.Console.WriteLine($"Нельзя делить на 0");
}
else
{
    double result = 1 / value;
    System.Console.WriteLine($"{value} -> {result}");
}