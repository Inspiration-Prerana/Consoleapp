using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            ClassLibraryTest.math.Rectangle1 r1 = new ClassLibraryTest.math.Rectangle1();
            Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            r1.Length = 10;
            Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            r1.Breadth = 12;
            Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            Console.ReadLine();
        }
    }
}
