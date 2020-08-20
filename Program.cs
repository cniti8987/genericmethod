using System;

namespace genericmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = calculator.areequal<string>("B", "B");
            if(equal)
            {
                Console.WriteLine("Equal");

            }
            else
            {
                Console.WriteLine("Not Equall");

            }


            bool equal1 = compare<int>.areequal(1, 2);
            if (equal1)
            {
                Console.WriteLine("Equal");

            }
            else
            {
                Console.WriteLine("Not Equal");

            }
        }
    }

    public class calculator
    {
        public static bool areequal<T>(T val1,T val2)
        {
            return val1.Equals(val2);
        }
    }
    public class compare<T>
    {
        public static bool areequal(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }


}
