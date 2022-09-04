// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}
int value = Prompt("Введите трехзначное число > ");

int SecondNumber(int value)
{
    int result = value % 100;
    result = result / 10;
    return result;
}

if (value < 1000 && value > 99)
{
    int secondNumber = SecondNumber(value);
    System.Console.WriteLine($"вторая цифра трезначного числа -> {secondNumber}");
}
else
{
    System.Console.WriteLine("Ошибка. Введите трехзначное положительное число");
}