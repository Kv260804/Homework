// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine($"Введите трёхмерный массив со значениями (x)x(y)x(z):");
// int x = InputNumbers("Введите x: ");
// int y = InputNumbers("Введите y: ");
// int z = InputNumbers("Введите z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// FillArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void WriteArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.Write($"x({i}) y({j}) ");
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"z({k})={array3D[i, j, k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,,] array3D)
// {
//     int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array3D.GetLength(0); x++)
//     {
//        for (int y = 0; y < array3D.GetLength(0); y++)
//         {
//             for (int z = 0; z < array3D.GetLength(1); z++)
//             {
//                 array3D[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }

int[] CreateArrayRandomizer(int min, int max)
{
    Random randomizer = new Random();
    int size = Math.Abs(max - min);
    int[] array = new int[size];

    for(int i = 0, num = min; i < size; i++, num++)
    {
        // var num = randomizer.Next(min, max);
        // if (!array.Contains(num))
        // {
        //     array[i] = num;
        //     i++;
        // }
        array[i] = num;
    }
    return array;
}

int[, ,] FillArray(int[, ,] emptyArray, int[] random)
{
    int x = emptyArray.GetLength(0);
    int y = emptyArray.GetLength(1);
    int z = emptyArray.GetLength(2);
    int size = random.Length-1;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0,size);
                if (random[index]!=0)
                {
                    emptyArray[i, j, k] = random[index];
                    random[index] = 0;
                    Swap(random, index, size);
                    size--;
                }
            }
        }
    }
    return emptyArray;
}

void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

void PrintArray(int[, ,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    for (int i = 0; i < x; i++)
    {
         for (int j = 0; j < y; j++)
         {
            for (int k = 0; k < z; k++)
            {
                Console.Write(" | "+array[i, j, k]+$" |({j},{k},{i}) ");
            }
            Console.WriteLine();
         }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int x = InputNumbers("x");
int y = InputNumbers("y");
int z = InputNumbers("z");
int[, ,] emptyArray = new int[x,y,z];

int min = InputNumbers("minRand");
int max = InputNumbers("maxRand");

if ((max - min) < x*y*z)
{
    Console.WriteLine("Диапазон чисел меньше чем, размерность массива");
    return;
}

int[] arrayRandomizer = CreateArrayRandomizer(min, max);
int[, ,] fullArray = FillArray(emptyArray,arrayRandomizer);
PrintArray(fullArray);