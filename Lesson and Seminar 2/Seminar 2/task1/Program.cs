// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int value = new Random().Next(10, 100);

System.Console.WriteLine(value);

int firsNumber = value / 10;
int secondNumber = value %10;

if( firsNumber > secondNumber)
{
    System.Console.WriteLine(firsNumber);
}
else
{
    System.Console.WriteLine(secondNumber);
}