using System;

namespace _22_02_22_classes_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int OpvragenTeller, OpvragenNoemer;
            Console.WriteLine("Wat is de teller?");
            OpvragenTeller= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is de noemer?");
            OpvragenNoemer = Convert.ToInt32(Console.ReadLine());
            Storage OpvragenBreuk = new Storage(OpvragenTeller,OpvragenNoemer);
            Console.WriteLine($"De uitkomst van {OpvragenTeller}/{OpvragenNoemer} is {OpvragenBreuk.breuk}");
        }
    }
}
