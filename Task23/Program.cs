// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

try
{
Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());

void ThirdDegree()
{
    int i = 1;
    while (i <= x)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
        i++;
    }
}
    ThirdDegree();
}
catch
{
    Console.WriteLine("Вводите только целые числа");
}
