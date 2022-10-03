// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int row, int colomns)
{
    int[,] array = new int[row, colomns];
    int number = row * colomns;
    int n = 1;
    int i = 0;
    int j = 0;
    while (n <= number)
    {
        array[i,j] = n;
        n++;
        if (i <= j + 1 && i + j < colomns - 1)
        j++;
        else if (i < j && i + j >= row - 1)
        i++;
        else if (i >= j && i + j > colomns - 1)
        j--;
        else
        i--;
    }
    return array;

}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    for (int i = 0; i < row; i ++)
    {
        for (int j = 0; j < colomns; j++)
        {
            Console.Write("| "+ array[i, j].ToString().PadLeft(2, '0') +" |");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк и столбцов: ");
int row = Convert.ToInt32(Console.ReadLine());
int colomns = row;
int[,] fullArray = FillArray(row, colomns);
PrintArray(fullArray);