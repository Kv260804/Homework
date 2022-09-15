// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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

string FindElement(int[,] array, int number)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < colomns; j++)
        {
            int checkItem = array[i,j];
            if(number == checkItem) return $"Элемент {number} находится в ячейке [{i},{j}]";
        }
        Console.WriteLine();
    }
    return $"Такого элемента нет в массиве"; 
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
Console.WriteLine("Какое число найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[,] fullArray = FillArray(row,colomns);
PrintArray(fullArray);
Console.WriteLine(FindElement(fullArray,number));