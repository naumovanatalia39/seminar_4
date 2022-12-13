Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (a != 0)
{
    a = a / 10; // a /= 10
    count++;
}
Console.WriteLine($"в числе {count} цифр");