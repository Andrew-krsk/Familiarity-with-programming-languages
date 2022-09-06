// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
// кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да


int value1 = new Random().Next(10, 100);
int value2 = new Random().Next(10, 100);
int value3 = new Random().Next(10, 100);

while (value1 %2 == 0 || value2 %2 == 0 || value3 %2 ==0)
{
    if (value1 %2 == 0)
    {
        System.Console.WriteLine($"{value1} -> Да");
        break;
    }
    else
    System.Console.WriteLine($"{value1} -> Нет");
   
    if (value2 %2 == 0)
    {
        System.Console.WriteLine($"{value2} -> Да");
        break;
    }
    else
    System.Console.WriteLine($"{value2} -> Нет");

    if (value3 %2 == 0)
    {
        System.Console.WriteLine($"{value3} -> Да");
        break;
    }
    else
    System.Console.WriteLine($"{value3} -> Нет");
}
