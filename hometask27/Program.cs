int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите число");
int res = 0;
while(a != 0)
{
    res = a % 10 + res;
    a = a / 10;
}
Console.WriteLine($"Сумма цифр в числе {res}");