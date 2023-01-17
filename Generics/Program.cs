using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Generics------");
            Console.WriteLine("Maximun string   is :");
            // Console.WriteLine(MaximumNumberCheck.MaximumIntegerNumber(100, 200, 300));
            //Console.WriteLine(MaximumNumberCheck.MaximumFloatNumber(1.11, 2.22, 4.44));
            Console.WriteLine(MaximumNumberCheck.MaximumStringNumber("Apple", "Peach", "Banana"));
        }
    }
}
