// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
// кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да


// int value1 = new Random().Next(10, 100);
// int value2 = new Random().Next(10, 100);
// int value3 = new Random().Next(10, 100);

// while (value1 %2 == 0 || value2 %2 == 0 || value3 %2 ==0)
// {
//     if (value1 %2 == 0)
//     {
//         System.Console.WriteLine($"{value1} -> Да");
//         break;
//     }
//     else
//     System.Console.WriteLine($"{value1} -> Нет");
   
//     if (value2 %2 == 0)
//     {
//         System.Console.WriteLine($"{value2} -> Да");
//         break;
//     }
//     else
//     System.Console.WriteLine($"{value2} -> Нет");

//     if (value3 %2 == 0)
//     {
//         System.Console.WriteLine($"{value3} -> Да");
//         break;
//     }
//     else
//     System.Console.WriteLine($"{value3} -> Нет");
// }

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(10, 100);
        index++;
    }
}

void PrintArray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while (col[position] %2 != 0)
    {
        System.Console.WriteLine($"{col[position]} -> Нет");
        position++;
    }
    System.Console.WriteLine($"{col[position]} -> Да");
}

int[] array = new int [10];

FillArray(array);

PrintArray(array);
System.Console.WriteLine();
