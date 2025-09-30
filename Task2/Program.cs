﻿using System;

namespace Task2
{
    public class Program
    {
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(min, max + 1);
            return arr;
        }

        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
                sum += n;
            return sum;
        }

        public static double GetAverage(int[] numbers)
        {
            int sum = GetSum(numbers);
            return (double)sum / numbers.Length;
        }

        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int n in numbers)
                if (n < min) min = n;
            return min;
        }

        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int n in numbers)
                if (n > max) max = n;
            return max;
        }

        public static void Main()
        {
            int[] arr = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Масив: " + string.Join(", ", arr));
            Console.WriteLine($"Сума: {GetSum(arr)}");
            Console.WriteLine($"Середнє: {GetAverage(arr):F2}");
            Console.WriteLine($"Мінімум: {GetMin(arr)}");
            Console.WriteLine($"Максимум: {GetMax(arr)}");
        }
    }
}
