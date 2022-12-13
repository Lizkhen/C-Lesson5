/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


Console.WriteLine ("Задайте длину массива");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Задайте минимальное число в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Задайте максимальное число в массиве");
int max = Convert.ToInt32(Console.ReadLine());
int [] array = new int [len];
Random random = new Random (); 
for (int i = 0; i < array.Length; i++)
{
    array [i] = random.Next (min,max+1);
}
Console.WriteLine (string.Join( ",", array));
Console.WriteLine("Сумма чисел, стоящих на нечетных позициях = " + SumEvenNumbers(array));

int SumEvenNumbers(int []array)
{   int sum = 0;
    for (int i=0; i <array.Length; i=i+2)
    {
        sum += array[i];
    }
    return sum;
}

