int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetProductNumbers (int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
        prod = prod * i; 
    }
    return prod;
}
int a = ReadInt("Введите число");
int result = GetProductNumbers(a);
Console.WriteLine($"Сумма чисел от 1 до {a} = {result}");