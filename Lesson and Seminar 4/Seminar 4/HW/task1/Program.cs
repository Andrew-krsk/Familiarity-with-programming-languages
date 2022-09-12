// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int Exponent (int value, int exp)
{
    int result = value;
    for (int i = 1; i < exp; i++)    
    {
        result = result * value;
    }
    return result;
}

int value = Prompt("Введите число А > ");
int exp = Prompt("Введите число B (степень в которую необходимо возвести число А) > ");
// int result = Exponent(value, exp);
// System.Console.WriteLine(result);
System.Console.WriteLine(Exponent(value, exp));
