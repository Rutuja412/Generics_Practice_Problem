using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Generics------");
            Console.WriteLine("Maximum Integer,float and string is :");
            Console.WriteLine(MaximumNumberCheck<int>.Maximum(100, 200, 300));
            Console.WriteLine(MaximumNumberCheck<float>.Maximum(1.11f, 2.22f, 4.44f));
            Console.WriteLine(MaximumNumberCheck<string>.Maximum("Apple", "Peach", "Banana"));
        }   
    }
}
