using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // “Hello, <name>!”, където <name> е въведеното преди това име.
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + '!');

        }
    }
}
