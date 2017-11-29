using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для проверки:");
            string str = Console.ReadLine();
            char[] temp = new char[str.Length];
            int j = 0, countNull = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    countNull++;
                    continue;
                }
                temp[j] = str[i];
                j++;
            }
            Array.Resize(ref temp, str.Length - countNull);
            string output = new string(temp);
            Console.Clear();
            Console.WriteLine(str);
            str = output;
            output = new string(output.ToCharArray().Reverse().ToArray());
            if (String.Compare(str, output, true) == 0)
            {
                Console.WriteLine("Строка ЯВЛЯЕТСЯ палиндромом");
            }
            else
            {
                Console.WriteLine("Строка НЕ ЯВЛЯЕТСЯ палиндромом");
            }

            Console.ReadLine();
        }
    }
}
