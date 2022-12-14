int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array [i] = ReadInt("Введите число");
}
Console.WriteLine(string.Join(", ", array));