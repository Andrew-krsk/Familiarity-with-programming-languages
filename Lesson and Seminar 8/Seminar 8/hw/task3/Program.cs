// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    result[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine("Такого произведения матриц не существует, так как число столбцов первой матрицы не совпадает с числом строк второй матрицы");
    }
    return result;
}

int[,] array1 = GenerateArray(3, 3, 1, 4);
PrintMatrix(array1);
int[,] array2 = GenerateArray(3, 1, 1, 4);
PrintMatrix(array2);
int[,] resultMatrix = MultiplicationMatrix(array1, array2);
PrintMatrix(resultMatrix);



