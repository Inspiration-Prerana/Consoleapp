using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.Computer
{
    public class Stack
    {
        private int[] _container = new int[10];
        private int count = 0;

        public int Count { get { return count; } }

        public void Push(int a)
        {
            if (count<10)
            {
                _container[count] = a;
                count++;
            }

        }

        public int Pop()
        {
            int ret = 0;
            if (count>=0)
            {
                ret = _container[count];
                _container[count] = 0;
                count--;
            }

            return ret;
        }


        public string DisplayAll()
        {
            int[] dest = new int[count];
            Array.Copy(_container, dest, count);
            string str = string.Join(",", dest);
            return str;
        }
    }
}
