// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

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

int MakeThreeDigitNumber (int value)
{
    while (value > 999)
    {
        int result = value/10;
        return result;
    }
    
} 

int ThirdNumber(int value)
{
    int result = value % 10;
    return result;
}

if (value > 99)
{
    int MakeThreeDigitNumber(value);
    int thirdNumber = ThirdNumber(value);
    System.Console.WriteLine($"Третья цифра заданного числа -> {thirdNumber}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
