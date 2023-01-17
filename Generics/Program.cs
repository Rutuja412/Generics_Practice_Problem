using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Generics------");
            Console.WriteLine("Maximum Integer,float and string is :");
             Console.WriteLine(MaximumNumberCheck.Maximum(100, 200, 300));
            Console.WriteLine(MaximumNumberCheck.Maximum(1.11, 2.22, 4.44));
            Console.WriteLine(MaximumNumberCheck.Maximum("Apple", "Peach", "Banana"));
        }
    }
}
