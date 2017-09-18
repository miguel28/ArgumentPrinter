using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
                Console.Write(arg + " ");
            Console.ReadLine();
        }
    }
}
