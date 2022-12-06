// Программа принимает на вход число N и выдает таблицу кубов от 1 до N.

Console.WriteLine ("Введите число:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("________________");
Console.WriteLine($"Таблица кубов чисел от  1 до {N}");
Console.WriteLine("________________");
int temp = 1;
while(temp<=N)
{
    double cube = Math.Pow(temp, 3);
    Console.WriteLine ($"{temp} --- {cube}");
    temp =temp+1;
}