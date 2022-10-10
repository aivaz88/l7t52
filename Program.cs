// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] myArray = RandomArray(m, n);
PrintArray(myArray);
for (int i = 0; i < myArray.GetLength(1); i++)
{
    Console.Write($"Среднее арифметическое значение {i} столбца равно:");
    AverageColumn(myArray, i);
}

void AverageColumn(int[,] newArray, int columnNumber)
{
    int averageVolue = 0;
    for (int i = 0; i < newArray.GetLength(1); i++) averageVolue += newArray[i, columnNumber];
    Console.WriteLine((double)averageVolue / newArray.GetLength(1));
}


int[,] RandomArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random randGenerator = new Random();
    for (int i = 0; i < m; i++) for (int j = 0; j < n; j++) newArray[i, j] = randGenerator.Next(0, 10);
    return newArray;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) Console.Write($"{newArray[i, j]}; ");
        Console.WriteLine("");
    }
}