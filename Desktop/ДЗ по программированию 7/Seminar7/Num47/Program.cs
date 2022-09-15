// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] FillArray(int row, int colomns)
{
    double[,] array = new double[row,colomns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            array[i,j] = new Random().NextDouble()*10;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < colomns; j++)
        {
            Console.Write("| "+Math.Round(array[i,j],1)+" |");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());
double[,] fullArray = FillArray(row, colomns);
PrintArray(fullArray);