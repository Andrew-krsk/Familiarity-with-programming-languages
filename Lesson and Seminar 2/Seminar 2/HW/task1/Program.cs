// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int value = new Random().Next(100, 1000);
System.Console.WriteLine(value);

int DelSecondNumber (int value)
{
    int result = value /100 * 10;
    result = result + value %10;
    return result;
}

System.Console.WriteLine(DelSecondNumber(value));