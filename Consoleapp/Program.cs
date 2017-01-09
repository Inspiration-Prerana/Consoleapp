using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c1=ClassLibraryTest.Computer;

namespace Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassLibraryTest.math.Rectangle r1 = new ClassLibraryTest.math.Rectangle(10, 12);
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //r1.Length = 12;
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //ClassLibraryTest.math.Rectangle1 r1 = new ClassLibraryTest.math.Rectangle1();
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //r1.Length = 10;
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //r1.Breadth = 12;
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            c1.CustomStack stack = new c1.CustomStack();

            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");

            stack.Push(1);
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            stack.Push(10);
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            stack.Push(14);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            stack.Pop();
            Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");


            Console.ReadLine();
        }
    }
}
