﻿// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

int FunctionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return FunctionAckerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    }
    else
        return n + 1;
}

int m = Prompt("Введите значение M -> ");
int n = Prompt("Введите значение N -> ");
System.Console.WriteLine(FunctionAckerman(m, n));
