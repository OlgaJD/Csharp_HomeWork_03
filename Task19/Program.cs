// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

try
{
    Console.Write("Введите пятизначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    void TestNumber()
    {
        string num = x.ToString();
        int n = num.Length;
        if (n == 5)
        {
            if (num[0] == num[4] && num[1] == num[3])
            {
                Console.WriteLine($"Число {x} - это палиндром.");
            }
            else Console.WriteLine($"Число {x} - это не палиндром.");
        }
        else
            Console.WriteLine("Надо вводить целое пятизначное число");
    }
    TestNumber();
}
catch
{
    Console.WriteLine("Вводите только целые числа");
}
