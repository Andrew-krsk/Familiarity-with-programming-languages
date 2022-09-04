// Напишите программу, которая будет принимать на вход пять чисел и 
// выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

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
// int number1 = Prompt("Введите первое число > ");
// int number2 = Prompt("Введите второе число > ");
// int number3 = Prompt("Введите третье число > ");
// int number4 = Prompt("Введите четвертое число > ");
// int number5 = Prompt("Введите пятое число > ");

// int summ = number1 + number2 + number3 + number4 + number5;
// int ave = summ/5;
// System.Console.WriteLine($"{number1}{number2}{number3}{number4}{number5} -> сумма {summ}, среднее {ave}");

int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Prompt($"Введите число {i + 1}:");
}
int summ = Summ(numbers);
double ave;

// for (int i = 0; i < numbers.Length; i++)
// {
//     summ += numbers[i];
// }
ave = summ / numbers.Length;

int Summ (int[] numbers)
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        summ += numbers[i];
    }
    return summ;
}

System.Console.WriteLine($" Сумма -> {summ}");
System.Console.WriteLine($" Среднее арифметическое -> {ave}");