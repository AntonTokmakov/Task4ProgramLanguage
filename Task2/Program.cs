Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int result = 0;
int temp;

while (num != 0)
{
    result += num % 10;
    num /= 10;
}
Console.WriteLine(result);
