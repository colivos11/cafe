using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyClass();
            Console.WriteLine($"Hello World {c1.ReturnMessage()}");
        }
    }
}
