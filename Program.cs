//using MyLib;
//using System;

using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int Input(string text) 
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        void FillArray(int[] array, int minValue=-9, int maxValue=9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++) 
            {
                array[i]=rnd.Next(minValue,maxValue);
            }
        }

        void PrintArray(int[] array)
        {
            for (int i=0; i< array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
                Console.WriteLine();
        }

        void FillArrayDouble(double[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble()* rnd.Next(minValue, maxValue);// *(maxValue - maxValue)+minValue;
                array[i] = Math.Round(array[i], 2);
            }
        }

        void PrintArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
        }



        void Task34() 
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
            //Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2

            int size = 5;
            int[] numbers = new int[size];
            int count = 0;
            FillArray(numbers, 100, 999);
            PrintArray(numbers);

            for (int i = 0;i<numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0) count++;
            }
            Console.WriteLine($"Количество чётных элементов: {count}") ;
                       
        }
        //Task34();

        void Task36() 
        {
            //Задача 36: Задайте одномерный массив, заполненный случайными числами.
            //Найдите сумму элементов с нечётными индексами.
            //[3, 7, 23, 12] -> 19
            //[-4, -6, 89, 6]-> 0
            int size = 5;
            int[] numbers = new int[size];
            int sum = 0;

            FillArray(numbers, -5, 5);
            PrintArray(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0) sum = sum + numbers[i];
            }
            Console.WriteLine($"Сумма нечётных элементов= {sum}");
        }

        //Task36();

        void Task38() 
        {
            //Задайте массив вещественных чисел.
            //Найдите разницу между максимальным и минимальным элементами массива.
            //[3,21 7,04 22,93 - 2,71 78,24] -> 80,95

            int size = 5;
            double[] numbers = new double[size];
            double minE = numbers[0];
            double maxE = numbers[0];
            FillArrayDouble(numbers);
            PrintArrayDouble(numbers);

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i]< minE) minE = numbers[i];
                else if (numbers[i]> maxE) maxE = numbers[i];   
            }

            Console.WriteLine($"Разница между максимальным и минимальным = {maxE - minE}");

        }
        Task38();


    }
}