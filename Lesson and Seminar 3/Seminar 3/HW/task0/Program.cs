// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int value = Prompt("Введите число:");

if (10000 <= value && value < 100000)
{
    if (value / 10000 == value % 10 && value / 1000 % 10 == value % 100 / 10)
    {
        System.Console.WriteLine($" Число {value} является полиндромом");
    }
    else
        System.Console.WriteLine($" Число {value} не является полиндромом");
}
else
System.Console.WriteLine("Введите положительное пятизначное число");