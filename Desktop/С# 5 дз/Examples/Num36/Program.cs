// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int[] array = new int [10];
int index = 0;
int summ = 0;
while (index < 10)
{
    array[index] = new Random().Next(-100,100);
    Console.Write (array[index] + ",");
    index++;
}
Console.WriteLine();
index = 1;
while(index < 10)
{
    summ = summ + array[index];
    index++;
    index++;
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях:" + summ);