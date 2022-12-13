/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.

[3 7 22 2 78] -> 76
Диапазон любой, ввод зависит от пользователя. (размер, значения)
*/
Console.WriteLine ("Задайте длину массива");
double [] A = new double [Convert.ToInt32(Console.ReadLine())];
Console.WriteLine ("Заполните массив вещественными числами");
for (int i = 0; i < A.Length; i++)
{
   A[i] = Convert.ToDouble(Console.ReadLine().ToString());
}
Console.WriteLine (string.Join( ", ", A));
Console.WriteLine ("Минимальный элемент " + MinNumber(A));
Console.WriteLine ("Максимальный элемент " + MaxNumber(A));
Console.WriteLine ("Разница между ними  " + (MaxNumber(A) - MinNumber(A)));

double MinNumber (double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
   return min; 
}

double MaxNumber (double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
   return max; 
}