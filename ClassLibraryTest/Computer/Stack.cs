using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.Computer
{
    public class Stack
    {
        private int[] _container;
        private int count = 0;


        public Stack(int Size)
        {
            _container = new int[Size];
        }
        public int Count { get { return count; } }

        public void Push(int a)
        {
            if (count<_container.Length)
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
                ret = _container[count-1];
                _container[count-1] = 0;
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

    public class CustomStack
    {
        private int[] _container=new int[0];

        public int Count { get { return _container.Length; } }
        public void Push(int a)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = a;
        }

        public int Pop()
        {
            int ret=0;
            if (_container.Length>=0)
            {
                ret = _container[_container.Length - 1];
                Array.Resize(ref _container, _container.Length - 1);
            }

            return ret;
        }

        public string DisplayAll()
        {
            string str = string.Join(",", _container);
            return str;
        }
    }
}
