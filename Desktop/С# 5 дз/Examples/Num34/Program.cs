//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int [10];
int index = 0;
int count = 0;
while (index < 10)
{
    array[index] = new Random().Next(100,1000);
    Console.Write (array[index] + ",");
    index++;
}
Console.WriteLine();
index = 0;
while(index < 10)
{
    if(array[index] % 2 == 0)
    {
count = count + 1;
    }
    index++;
}
Console.WriteLine("Чётых чисел в массиве: " + count);