using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.math
{
    public class Arithmetic
    {


        public int add(int a,int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int add(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = +a[i];
            }

            return sum;
        }
    }

    public class Rectangle1
    {
        public Rectangle1()
        {

        }

        private int area;
        private int perimeter;

        public int Area
        {
            get { return area; }
        }
        public int Perimeter
        {
            get { return perimeter; }
        }
        private int length;
        public int Length
        {
            get { return length; }
            set
            {
                length = value;
                area = length * breadth;
                perimeter = 2 * (length + breadth);
            }
        }
        private int breadth;

        public int Breadth
        {
            get { return breadth; }
            set
            {
                breadth = value;
                area = length * breadth;
                perimeter = 2 * (length + breadth);
            }
        }
        

    }

    public class Rectangle
    {
        public int Length{ get; set; }
        public int Breadth { get; set; }
        public Rectangle()
        {

        }
        /// <summary>
        /// Creates a new object of Rectangle
        /// </summary>
        /// <param name="length">Length of a rectangle </param>
        /// <param name="breadth">Breadth of a rectangle</param>
        public Rectangle(int length, int breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }
        public int Perimeter
        {
            get { return 2 * (this.Length + this.Breadth); }
        }

        public int Area
        {
            get { return this.Length * this.Breadth; }
        }
    }
























}
