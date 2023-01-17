using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Generics------");
            Console.WriteLine("Maximum Integer,float and string is :");
           
             int[] intArray = { 1, 2, 4,5,6 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 1.11, 2.22, 4.44,7.77,8.88 };
            GenericMaximum<double> doublegeneric = new GenericMaximum<double>(doubleArray);
            doublegeneric.PrintMaxValue();

            string[] stringArray = { "22", "33", "44","55","66" };
            GenericMaximum<string> stringgeneric= new GenericMaximum<string>(stringArray);
            stringgeneric.PrintMaxValue();
        }   
    }
}
