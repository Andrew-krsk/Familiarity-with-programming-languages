// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

int Prompt(string message)
{
    Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

int value = Prompt("Введите день недели > ");
if (value < 0 || value > 7)
{
    System.Console.WriteLine(" Нет такого дня недели, введите значение от 1 до 7 ");
}
else
{
    int daysValue = value - 1;
    System.Console.WriteLine($"{value} -> {days[daysValue]}");
}