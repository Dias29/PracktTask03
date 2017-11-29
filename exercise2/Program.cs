using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите размеры массивов:");

            WriteLine("Массив М:");
            var valueM = Convert.ToInt32(ReadLine());
            WriteLine("Массив N:");
            var valueN = Convert.ToInt32(ReadLine());
            Random rand = new Random();
            int count = 0;
            int[] A = new int[valueM];
            int[] B = new int[valueN];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(15);
            }

            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rand.Next(15);
                for (int j = 0; j < A.Length; j++)
                {
                    if (B[i] == A[j])
                    {
                        count++;
                    }
                }
            }

            PrintArr("Массив A", A);
            PrintArr("Массив B", B);

            if (count != 0)
            {
                int[] AB = new int[count];
                int z = 0;
                for (int i = 0; i < B.Length; i++)
                {
                    for (int j = 0; j < A.Length; j++)
                    {
                        if ((B[i] == A[j]) && (!AB.Contains(B[i])))
                        {
                            AB[z] = B[i];
                            z++;
                        }
                    }
                }

                Array.Resize(ref AB, z);
                PrintArr("Массив общий", AB);
            }
            else
            {
                WriteLine("Общих элементов в массивах нет");
            }

            ReadLine();
        }

        static void PrintArr(string text, int[] arr)
        {
            WriteLine(text + ": ");
            for (int A = 0; A < arr.Length; A++)
            {
                Write(arr[A] + "\t");
            }
            WriteLine();
        }
    }
}
