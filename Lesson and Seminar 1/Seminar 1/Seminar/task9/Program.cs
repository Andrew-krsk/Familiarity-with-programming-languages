// вычислить числа Фибонначи
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
int value = Prompt("Введите число > ");
if (value < 0)
{
    System.Console.WriteLine("Число должно быть больше 0");
}
else
{
    System.Console.WriteLine($"Номер числа последовательности Фибонначи {value}. Значение числа -> {Fibonnachi(value)}");
}

int Fibonnachi(int value)
{
    int fibonnachi = 0;
    int tempVar1 = 0;
    int tempVar2 = 1;
    for ( int i = 0; i <= value; i++)
    {
        fibonnachi = tempVar1 + tempVar2; 
        tempVar1 = tempVar2;
        tempVar2 = fibonnachi;
    }
    return tempVar1;
    
}