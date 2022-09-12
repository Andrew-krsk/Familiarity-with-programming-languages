// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

int Summ(int value)
{
    int summ = 0;
    while (value / 10 > 0)
    {
        summ = summ + value % 10;
        value = value / 10;
    }
    int result = value + summ;
    return result;
}

int value = Prompt("Введите число > ");
int result = Summ (value);
System.Console.WriteLine($"{value} - > {result}");