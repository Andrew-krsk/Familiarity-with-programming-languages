// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1); //it's not a question to return the answer. Better use "array" or "generatedArray"
    }
    return answer;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.Write("-> ");
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        count = count + array[i];
    }
    return count;
}

int[] array = GenerateArray(5, -9, 9); //magic numbers, better to use Prompt() to input these values
PrintArray(array);
System.Console.WriteLine($"Cумма элементов, стоящих на нечетных пзициях = {Count(array)}"); //позициях
