// Программа принимает на вход координаты двух точек и находит расстояние
// между ними в 3Д пространстве.

Console.WriteLine("Введите координаты точки А :");
Console.WriteLine("Введите координату ХА");
int XA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату YА");
int YA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату ZА");
int ZA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B :");
Console.WriteLine("Введите координату ХB");
int XB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату YB");
int YB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату ZB");
int ZB = int.Parse(Console.ReadLine());
double XAB = Math.Pow((XB-XA), 2);
double YAB = Math.Pow((YB-YA), 2);
double ZAB = Math.Pow((ZB-ZA), 2);
double result = Math.Sqrt((XAB+YAB+ZAB));
System.Console.WriteLine($"длина отрезка = {result}");