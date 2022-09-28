using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SearchNumInString
{
    class Program
    {
        static void Sort(int nums)
        {
            // сортировка
            int tmp;
            for (int i = 0; i < nums - 1; i++)
            {
                for (int j = i + 1; j < nums; j++)
                {
                    if (i > j)
                    {
                        tmp = i;
                        i = j;
                        j = tmp;
                    }
                }
            }
            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums; i++)
            {
                Console.Write(nums + " ");
            }
        }
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[-]*\d*");
            Console.WriteLine("Введите строку: ");
            MatchCollection _matches = regex.Matches(Console.ReadLine());
            foreach (int item in _matches)
            {
                if (item.ToString().Length!=0)
                {
                    Console.Write(item + " ");
                }
                Sort(item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
