// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Random rnd = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i]= rnd.Next(100);
    Console.WriteLine(array[i]);
}