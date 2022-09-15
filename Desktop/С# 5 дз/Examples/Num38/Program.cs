// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
int[] array = new int [10];
int index = 0;
// int nextIndex = 1;
// int max = 0;
// int min = 0;
// int diff = 0;
while (index < 10)
{
    array[index] = new Random().Next(0,101);
    Console.Write (array[index] + ",");
    index++;
}
Console.WriteLine();
int result = array.Max() - array.Min();
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + result);
// index = 0;
// while (nextIndex < 10)
// {
//   if  (array[index] > array[nextIndex])
//   {
//     max = array[index];
//   }
//   else
// //   if (array[index] < array[nextIndex])
//   {
//     max = array[nextIndex];
//   }
//   index++;
//   nextIndex++;
// }
// Console.WriteLine("Максимальный элемент массива: "+ max);
// index = 0;
// nextIndex = 1;
// while (nextIndex < 10)
// {
//   if  (array[index] < array[nextIndex])
//   {
//     min = array[index];
//   }
//   else
// //   if(array[index] > array[nextIndex])
//   {
//     min = array[nextIndex];
//   }
//   index++;
//   nextIndex++;
// }
// Console.WriteLine("Минимальный элемент массива: " + min);
// diff = max - min;
// Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + diff);

