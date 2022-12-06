// Программа прнимает на вход пятизначное число и проверяет
// является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число :");
int num = int.Parse(Console.ReadLine());
int temp=num;
int rev=0;
while (temp>0)
{
rev=(rev*10)+temp%10;
temp=temp/10;
}
 if (rev == num)
 {
    Console.WriteLine($"Число {num} является палиндромом");
 }
 else
 {
    System.Console.WriteLine($"Число {num}  не является палиндромом");
 }