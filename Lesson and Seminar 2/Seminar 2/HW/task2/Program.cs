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

int MakeThreeDigitNumber (int value)
{
    while (value > 999)
    {
        value = value/10;
    }
    return value;
} 

int ThirdNumber(int value)
{
    int result = value % 10;
    return result;
}

int value = Prompt("Введите число > ");

if (value > 99)
{
    int makeThreeDigit =  MakeThreeDigitNumber(value);
    System.Console.WriteLine(makeThreeDigit);

    int thirdNumber = ThirdNumber(makeThreeDigit);
    System.Console.WriteLine($"Третья цифра заданного числа -> {thirdNumber}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
