using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddnumber = 0;
            uint evennumber = 0;

            int oddnumbersum= 0;
            int evennumbersum= 0;

            Console.WriteLine("Введите начальный диапазон");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечный диапазон");
            int limit = int.Parse(Console.ReadLine());

            while (start <= limit) 
            { 
                if (start % 2 == 0)
                {
                    evennumber++;
                    evennumbersum = evennumbersum + start;
                }
                else
                {
                    oddnumber++;
                    oddnumbersum = oddnumbersum + start;
                }
                start++;
            }
            Console.WriteLine("Количество четных чисел = " + evennumber);
            Console.WriteLine("Количество нечетных чисел = " + oddnumber);
            Console.WriteLine("Сумма четных чисел = " + evennumbersum);
            Console.WriteLine("Сумма нечетных чисел = " + oddnumbersum);

            Console.ReadLine();

        }
    }
}
