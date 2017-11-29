using System;

namespace PracktTask03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneDimensArray = new int[5];

            //заполнение одномерного массива
            Console.WriteLine("Введите 5 элемента массива: ");
            for (int i = 0; i < oneDimensArray.Length; i++)
            {
                oneDimensArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //вывод одномерного массива
            int sum = 0; int composition = 1;
            Console.WriteLine("\nМассив из 5 элементов: ");
            for (int i = 0; i < oneDimensArray.Length; i++)
            {
                Console.Write(oneDimensArray[i] + " ");
                sum = sum + oneDimensArray[i];
                composition = composition * oneDimensArray[i];
            }

            Array.Sort(oneDimensArray);

            int min = oneDimensArray[0];
            int max = oneDimensArray[oneDimensArray.Length - 1];


            Console.WriteLine("\nМаксимальный элемент: " + max);
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Сумма массива: " + sum);
            Console.Write("Произведение массива: " + composition);

            //заполнение и вывод двумерного массива
            double[,] twoDimensArray = new double[3, 4];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    twoDimensArray[i, j] = rand.Next(0, 100) / 10.0;
                }

            Console.WriteLine("\n\nМассив 3х4: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(twoDimensArray[i, j] + "    ");
                }
                Console.WriteLine();
            }

            double min2 = twoDimensArray[0, 0];
            double max2 = twoDimensArray[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (twoDimensArray[i, j] < min2)
                    {
                        min2 = twoDimensArray[i, j];
                    }
                    if (twoDimensArray[i, j] > max2)
                    {
                        max2 = twoDimensArray[i, j];
                    }

                }
            }
            Console.Write("\nМинимальный элемент: " + min2);
            Console.Write("\nМаксимальный элемент: " + max2);

            Console.ReadLine();
        }
    }
}
