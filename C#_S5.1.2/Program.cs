using System;

namespace C__S5._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int size = 4;
// int[] numbers = new int[size];
// int sumnumbers=0;
// for (int i = 0; i < numbers.Length; i++)
// {
// numbers[i]= new Random().Next(0,100);
// System.Console.Write(numbers[i]+ " ");
// if(numbers[i]%2==1)
// {
// sumnumbers=sumnumbers+numbers[i];
// }
// }
// Console.(sumnumbers);

int size = 8;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sumNumbersEvenIndex = 0;

for (int i = 1; i < numbers.Length; i += 2)
{
    sumNumbersEvenIndex += numbers[i];
}
Console.Write(sumNumbersEvenIndex);

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


        }
    }
}
