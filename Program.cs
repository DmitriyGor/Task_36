/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
** сумму элементов, стоящих на чётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] resultArray = new int [size];
    for (int i = 0; i < size; i++) // i < size = i < resultArray.Length
    {
        resultArray[i] = new Random ().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

Console.Write("Введите количество элементов массива: "); // Введите число a
int sizeElement = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray (sizeElement, -99, 99);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int indexOfOdd = 0; // количество четных чисел
int indexOfEven = 0; // количество нечетных чисел
for (int i = 0; i < array.Length; i ++) // i < size = i < array.Length
{
    if (i % 2 > 0)
    {
       indexOfOdd += array[i]; 
    }
    else
       indexOfEven += array[i]; 
}    
Console.WriteLine($"Cумма элементов,стоящих на НЕЧЕТНЫХ позициях массива равна : {indexOfOdd}");
Console.WriteLine($"Cумма элементов,стоящих на ЧЕТНЫХ позициях массива равна : {indexOfEven}");