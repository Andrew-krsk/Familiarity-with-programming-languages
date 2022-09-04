// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

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
int value = Prompt("Введите число > ");

if (value < 1000 && value > 99)
{
    int result = value % 10;
    System.Console.WriteLine($"последняя цифра трезначного числа -> {result}");
}
else 
{
    System.Console.WriteLine("Введите трехзначное число");
}