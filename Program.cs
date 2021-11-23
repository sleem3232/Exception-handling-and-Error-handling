using System;

namespace Exception_handling_and_Error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Democlass demo = new Democlass();
            int result = demo.grandparent(5);

            Console.WriteLine($"the result for poistin is : {result}");
            Console.ReadKey();
        }
    }
}
