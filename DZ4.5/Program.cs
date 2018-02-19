using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a1 = float.Parse(Console.ReadLine());
            float a = 20.50f;
            float b = 30.75f;

            if (a1 < a)
            { Console.WriteLine("ВНИМАНИЕ ЦЕНА ОПУСТИЛАСЬ!!!"); }

            else if (a1 > b)
            { Console.WriteLine("ВНИМАНИЕ ЦЕНА ПОДНЯЛАСЬ!!!"); }

            else if (a1 >= a || a1 <= b)
            { Console.WriteLine("Все ОК"); }


            Console.Read();

        }
    }
}
