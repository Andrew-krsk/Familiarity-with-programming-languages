// // Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// // 34, 5 -> не кратно, остаток 4 
// // 16, 4 -> кратно

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
int number1 = Prompt("Введите первое число > ");
int number2 = Prompt("Введите второе число > ");
int value = number2 % number1;
if (value !=0)
{
    
    System.Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {value}");
}
else
{
    System.Console.WriteLine($"{number2}, {number1} -> кратно");
}
