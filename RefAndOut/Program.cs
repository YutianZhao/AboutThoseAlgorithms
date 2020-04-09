using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Addition(a);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        static void Addition(int a)
        {
            a += 5;
        }

        static void AdditionWithRef(ref int a)
        {
            a += 2;
        }
    }

    class TempClass
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }
    }
}
