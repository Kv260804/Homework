// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = InputNumbers("Введите количество строк 1-й матрицы: ");
int n = InputNumbers("Введите количество столбцов 1-й матрицы и строк 2-й матрицы: ");
int p = InputNumbers("Введите число столбцов второй матрицы: ");
int range = InputNumbers("Диапазон чисел будет от 1 до  ");

int[,] firstMatrix = new int[m, n];
FillArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
FillArray(secondMatrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secondMatrix);

int[,] resultMatrix = new int [m, p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и  второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrixnew, int[,] secondMatrixnew,int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0);i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " | ");
        }
        Console.WriteLine();
    }
}