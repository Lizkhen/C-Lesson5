/*Задача 34: Задайте массив заполненный случайными положительными 
 трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
Диапазон трехзначных чисел, ввод случайный.*/
Console.WriteLine ("Задайте длину массива");
int len = Convert.ToInt32(Console.ReadLine());

int [] array = new int [len];
Random random = new Random (); 
for (int i = 0; i < array.Length; i++)
{
    array [i] = random.Next (100,1000);
}
Console.WriteLine (string.Join( ",", array));
Console.WriteLine ("Четных чисел в массиве "+ EvenNumbers (array));

int EvenNumbers (int [] array)
{
     int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            count++;
        }

    } 
    return count;
}