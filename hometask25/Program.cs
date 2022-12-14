int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int a = ReadInt("Введите первое число");
int b = ReadInt("Введите второе число");
int res = 1;
for(int i = 1; i <= b; i++)
{
    res = res * a;
}
Console.WriteLine(res);