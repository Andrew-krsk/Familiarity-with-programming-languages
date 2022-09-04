// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

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
bool remains = (value % 7 ==0) && (value % 23 ==0);
if (remains)
{
    System.Console.WriteLine("Да");
}
else{
    System.Console.WriteLine("Нет");
}

