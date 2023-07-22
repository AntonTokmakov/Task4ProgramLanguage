Console.WriteLine("Введите массив");
List<int> array = new List<int>();

while (true)
{
    string num = Console.ReadLine();
    if (num.Equals("Stop") || num.Equals("stop")) break;
    array.Add(int.Parse(num));
}

Console.WriteLine(string.Join(", ", array));