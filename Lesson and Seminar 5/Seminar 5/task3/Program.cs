// // Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

const int MIN_ELEMENTS = -99; // constants must go on top!
const int MAX_ELEMENTS = 99;

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ "\t");
    }
    System.Console.WriteLine();
}

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}

bool SearchResult(int[] array, int searchNum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchNum)
        {
            return true;
        }
    }
    return false;
}

int ArrayLen = Prompt("Введите длину массива > ");
int[] array = GenerateArray(ArrayLen, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
int searchNum = Prompt("Введите искомое число > ");

if (SearchResult(array, searchNum)) //you can make it as function btw void Result()
{
    System.Console.WriteLine("ok"); // output difined as "нет" or "да", pay attention
}
else
{
    System.Console.WriteLine("not ok ^_^"); //output difined as "нет" or "да", pay attention
}
// there is no validation check here! try to enter -2 as length of array or 0. Exception neaded.
