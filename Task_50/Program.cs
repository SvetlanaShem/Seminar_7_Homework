Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.Write("Введите номер строки числа: ");
int mUser = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите номер столбца числа: ");
int nUser = int.Parse(Console.ReadLine() ?? "");
FindNumber(mUser, nUser, array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int m, int n, int[,] arr)
{
    if (m <= arr.GetLength(0) && n <= arr.GetLength(1))
    {
        int i = m - 1;
        int j = n - 1;
        Console.WriteLine($"Искомое число {arr[i, j]}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}