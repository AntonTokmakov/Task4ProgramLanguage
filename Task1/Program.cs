// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int step = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 1; i <= step ; i++)
{
    result *= number;
}
Console.WriteLine(result);