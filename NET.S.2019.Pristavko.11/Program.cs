namespace NET.S._2019.Pristavko._11
{
    using System;
    using NET.S._2019.Pristavko._11.Clocks;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Clock clock = new Clock();
            FirstClass s1 = new FirstClass();
            SecondClass s2 = new SecondClass();
            ThirdClass s3 = new ThirdClass();
            s1.Register(clock);
            s2.Register(clock);
            clock.Countdown(2500);            
            clock.Countdown(6000);
            s3.Register(clock);
            clock.Countdown(4000);
            s3.Unregister(clock);
            clock.Countdown(4000);
            Console.ReadLine();

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
