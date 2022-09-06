// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

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

int value = Prompt("Введите цифру, обозначающую день недели > ");

if (1 <= value && value < 8)
{
    if ( 1 <= value && value < 6)
    {
        System.Console.WriteLine($"Этот день не выходной");
    }
    else
    System.Console.WriteLine($"Этот день выходной");
}
else
System.Console.WriteLine($"Введите число от 1 до 7");

