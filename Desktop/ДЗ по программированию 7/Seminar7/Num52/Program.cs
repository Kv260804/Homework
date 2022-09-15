// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] FillArray(int row, int colomns)
{
    int[,] array = new int[row, colomns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}


double[] MiddleSum(int[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    double[] result = new double[colomns];
    for (int i = 0; i < colomns; i++)
    {
        int resultSum = 0;
        for (int j = 0; j < row; j++)
        {
            resultSum += array[j,i];
        }
        result[i] = Math.Round((double)resultSum/(double)row,1);
    }
    return result;
}


void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < colomns; j++)
        {
            Console.Write("| "+array[i,j]+" |");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());
int[,] fullAray = FillArray(row, colomns);
PrintArray(fullAray);
double[] middleSumArray = MiddleSum(fullAray);
Console.WriteLine("Сумма столбцови| {0} |",string.Join(" | ",middleSumArray));