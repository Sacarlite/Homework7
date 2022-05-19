/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4, m = 3;
            double[,] arr=new double[n,m];
            arr = AddArray(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    Console.Write($"arr[{i}][{j}]=");
                    Console.WriteLine(arr[i,j]);
                }
            }
        }
 static double[,] AddArray(double[,] arr)
        {
            var rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rand.Next()+rand.NextDouble();
                }
            }
            return arr;
        }

    }
}*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5, m = 5;
            double[,] arr = new double[n, m];
            int num = 17;
            var rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.NextDouble();
                }
            }
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i + 1}][{j + 1}]=");
                    Console.WriteLine(arr[i, j]);

                }
            }
            AddArray(arr, num);

        }
        static void AddArray(double[,] arr, int num)
        {
            if (arr.GetLength(0) * arr.GetLength(1) < num)
            {
                Console.Write("Такого элемента не существует");
            }

            else
            {
                Console.Write($"Элемент под номером{num}");
                int pos1 = 0;
                while (num - arr.GetLength(1) > 0)
                {
                    num = num - arr.GetLength(1);
                    pos1++;
                }
                int pos2 = num;
                Console.Write($"arr[{pos1 + 1}][{pos2}]=");
                Console.WriteLine(arr[pos1, pos2 - 1]);
            }



        }
    }
}*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5, m = 5;
            int[,] arr = new int[n, m];
            int num = 1;
            var rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1,10);
                }
            }
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i + 1}][{j + 1}]=");
                    Console.WriteLine(arr[i, j]);

                }
            }
            AddArray(arr, num);

        }
        static void AddArray(int[,] arr, int num)
        {
            

            
            
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    int sum = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sum += arr[i, j];

                    }
                    Console.WriteLine($"Среднее арифметическое = {sum/ arr.GetLength(1)}");
                }
                
            



        }
    }
}*/