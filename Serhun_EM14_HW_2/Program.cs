using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace Serhun_EM14_HW_2
{
    internal class Program
    {
        static void sortArray(int[] array, char route)
        {
            if (route == '<')
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }
        static void errorMessage(string message)
        {
            throw new Exception(message);
        }
        static int[][] createArray(int n, int m)
        {
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[m];
            }
            return matrix;
        }
        static int[][] fillArray(Random r, int min, int max, int n, int m)
        {
            int[][] matrix = createArray(n, m);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = r.Next(min, max);
                }
            }
            return matrix;
        }
        static int[] fillArray(Random r, int n, int min, int max)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(min, max);
            }
            return array;
        }
        static void printArray(int[][] matrix, int n, int m) {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i][j] + "  ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }
        static void printArray(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static int readInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            //Task 1
            /*
            try
            {
                int n = 10, m = 10;
                int[][] matrix = fillArray(r, 10, 90, n, m);
                int min, max;
                Console.WriteLine("Matrix:");
                printArray(matrix, n, m);
                min = readInt("Enter search rang:\nmin: ");
                max = readInt("max: ");
                int count = 0;
                Console.WriteLine("Numbers divisible by 5");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i][j] >= min && matrix[i][j] <= max)
                            count++;
                        if (matrix[i][j] % 5 == 0)
                            Console.Write(matrix[i][j] + " ");
                    }
                }
                Console.WriteLine("Number of numbers betwen " + min + " and " + max + ": " + count);
            }
            catch (Exception ex)
            {
                errorMessage(ex.Message);
            }
            */
            //Task 2
            /*
            try
            {
                int n = 100, min = 100, max = 900;
                int[] array =fillArray(r, n, min, max);
                Console.WriteLine("Array: ");
                printArray(array, n);
                sortArray(array, '>');
                Console.WriteLine("Sorted array: ");
                printArray(array, n);
                Console.WriteLine("Second minimal number is: " + array[1]);
            }
            catch (Exception ex)
            {
                errorMessage(ex.Message);
            }
            */
            //Task 3
            /*
            try
            {
                int[] count = new int[26];
                bool show = true;
                string text;
                Console.WriteLine("Enter text: ");
                text = Console.ReadLine();
                Console.Write("Display zero values?(- or +): ");
                string display = Console.ReadLine();
                switch (display)
                {
                    case ("-"):{
                        show = false;
                        break;
                    }
                    case ("+"):{
                        show = true;
                        break;
                    }
                    default:{
                        errorMessage("Error! Invalid input");
                        break;
                    }
                }
                    for (int i = 0; i < text.Length - 1; i++)
                    {
                    if (text[i] != ' ' && text[i] != '\0')
                        {
                            char c = char.ToUpper(text[i]);
                            count[c - 'A']++;
                        }
                    }
                for(int i = 0; i < count.Length; i++)
                {
                    if (show)
                    {
                        Console.Write((char)('A' + i) + ": " + count[i]+"  ");
                        if (i % 5 == 0)
                            Console.WriteLine();
                    }
                    else
                    {
                        if (count[i] != 0)
                            Console.WriteLine((char)('A' + i) + ": " + count[i]);
                    }
                }
            }
            catch (Exception ex) {
                errorMessage(ex.Message);
            }
            */
            //Task 4
            /*
            int n = 20;
            int[] array = new int[n];
            array = fillArray(r, n, 10, 60);
            printArray(array, n);
            int result = array[0] + array[1] + array[2];
            int index=0;
            for (int i = 0; i < array.Length - 2; i++)
            {
                int result2 = array[i]+array[i+1]+array[i+2];
                if(result2 > result)
                {
                    result = result2;
                    index = i;
                }
            }
            Console.WriteLine("Max sum of subarray of 3 elements: " + result + " = " + array[index] + " + " + array[index+1] + " + " + array[index+2]);
            */
        }
    }
}
