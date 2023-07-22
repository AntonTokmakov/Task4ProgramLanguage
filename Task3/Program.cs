Console.WriteLine("Введите массив");
List<int> arr = InList();
PrintArray(arr);

List<int> InList()
{
    int count = 0;
    List<int> array = new List<int>();
    while (count != 8)
    {
        string num = Console.ReadLine();
        if (num.Equals("Stop") || num.Equals("stop")) break;
        array.Add(int.Parse(num));
        count++;
    }   
    return array; 
}

void PrintArray(List<int> array)
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}