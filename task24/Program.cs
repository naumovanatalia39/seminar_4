﻿//метод считывает целое число от пользователя( конвертирует введенные данные в число)
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//возвращает сумму от 1 до number
int GetSumToNumber(int number)
{
    int sum = 0;
    for (int i =1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int A = ReadInt("Введите число: ");
int result = GetSumToNumber(A);
Console.WriteLine($"Сумма чисел от 1 до {A} = {result}");
