using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Pristavko._11
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Fibonacci.Fibonaccis(21))
            {
                Console.WriteLine(item);
            }
            int i = BinarrySearch.Search(new dynamic[] { 4, 6, 43, 234, 733.5, 4223, 42523 }, 4);
            Console.WriteLine(i);
            char[] strs = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            int y = BinarrySearch.Search(strs, 'Я');
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
