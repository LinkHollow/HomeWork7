// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GetArray(4, 3, 0, 10);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Среднее арифмитическое каждого столбца: ");
Console.WriteLine(string.Join(";" ,ArithmeticMean(array)));


//------------------Method---------------------------

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] =new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

double [] ArithmeticMean(int [,] array)
{
    double [] ArMean = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            ArMean[j] += (((Convert.ToDouble(array[i, j])) / array.GetLength(0)));
        }
        }
    return ArMean;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
                Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}