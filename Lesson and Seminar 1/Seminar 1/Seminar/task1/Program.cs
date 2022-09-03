// Напишите программу, которая на вход принимает число и выдаёт его квадрат
// (число умноженное на само себя).

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    Console.Write(message);                    // вывод приглашения
    string strValue;                           // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";      // вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);           // преобразование строки в целое число 
    return value;
}

int value = Prompt("Введите число > ");
int result = value * value;                // вычисление квадрата (заносим в переменную result)
System.Console.WriteLine($"Квадрат числа {value} равен {result}");     //вывод результата