// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int number1 = new Random().Next(1, 10000);
System.Console.WriteLine(number1);
int max = 0;
while (number1 > 0)
{
    int temp = number1 % 10;
    if (max < temp)
        max = temp;
    number1 = number1 / 10;
}
System.Console.WriteLine(max);