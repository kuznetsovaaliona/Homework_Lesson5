//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindEvenSum(int[] array)
// {
//     int sum= 0;
//     for(int i = 0;i < array.Length;i++)
//     {
//         if(array[i] %2 == 0) sum+= 1;
        
//     }
//     Console.WriteLine($"Sum of even numbers in array -> {sum}");
// } 

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// FindEvenSum(myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindOddIndexSum(int[] array)
// {
//     int sum= 0;
//     for(int i = 0;i < array.Length;i++)
//     {
//         if(i %2 != 0) sum += array[i];
        
//     }
//     Console.WriteLine($"Sum of odd index numbersin array -> {sum}");
// } 

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// FindOddIndexSum(myArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

 double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    Random rand = new Random ();
    for(int i = 0;i < size; i++)
    {
        array[i] = Math.Round(rand.Next(minValue, maxValue + 1)*0.1,1);
    }
    return array;
}

void ShowArray (double[] array)
{
    for(int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FindDiffMinMax(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];

    for(int i = 0;i < array.Length;i++)
    {
        if(array[i]> max) max = array[i];
        if(array[i]<min) min = array[i];
    }
    diff = max-min;
    Console.WriteLine($"Sum of odd index numbersin array -> {diff}");
} 

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
FindDiffMinMax(myArray);