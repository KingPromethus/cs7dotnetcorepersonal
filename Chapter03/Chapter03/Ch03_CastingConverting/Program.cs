using System;
using static System.Console;
using static System.Convert;

namespace Ch03_CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c;
            Console.WriteLine(d);

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e} and f is {f}");
            e = long.MaxValue;
            f = (int)e;
            Console.WriteLine($"e is {e} and f is {f}");

            double g = 9.8;
            int h = ToInt32(g);
            Console.WriteLine($"g is {g} and h is {h}");

            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;
            Console.WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            Console.WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            Console.WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
            Console.WriteLine($"l is {l}, ToInt(l) is {ToInt32(l)}");

            int number = 12;
            Console.WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}.");

            Write("How many eggs are there? ");
            int count;
            string input = ReadLine();
            if(int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }
        }
    }
}