// Вычислить факториал числа
int Prompt(string message)
{
    Console.Write(message);                    // вывод приглашения
    string strValue;                           // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";      // вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);           // преобразование строки в целое число 
    return value;
}

int value = Prompt("Введите число > ");

if (value < 0)
{
    System.Console.WriteLine("Число должно быть больше 0");
}
else
{
    System.Console.WriteLine($"Факториал числа {value} -> {Factorial(value)}");
}

int Factorial(int value)
{
    int factorial = 1;
    for ( int i = 1; i <= value; i++)
    {
        factorial = factorial * i; 
    }
    return factorial;
    
}
