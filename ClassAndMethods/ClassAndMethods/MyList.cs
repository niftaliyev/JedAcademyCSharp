using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    public class MyList
    {
        private const int length = 10;
        int[]array = new int[length];

        public int[] getArray()
        {
            return array;
        }

        public int getLength()
        {
            return length;
        }
    }
}
