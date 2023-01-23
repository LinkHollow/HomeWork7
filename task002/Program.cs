// Задача 50. Напишите программу, которая на вход принимает число,
//  и проверяет есть ли такое число в двумерном массиве, 
//  а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine("Введите число для нахождения совпадений с элементами массива: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] array = GetArray(4, 3, 0, 10);
PrintArray(array);
System.Console.WriteLine();
FindMatch(array, number);

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

void FindMatch(int [,] array, int num)
{
    int find = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == num)
            {
            find = 1;
            break;
            }          
        }        
    }
    if(find != 0)
    {
        System.Console.WriteLine($"Число {num} присутствует в массиве");
    }
    else
    {
        System.Console.WriteLine($"Число {num} отсутствует в массиве");
    }
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