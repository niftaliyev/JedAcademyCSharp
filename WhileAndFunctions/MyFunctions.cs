using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndArrays2
{
    public static class MyFunctions
    {
        public static int[] returnArrayForTest()
        {
            int[] numbers = new int[] { 5, 7, 1, 9, 6, 8, 7, 15, 3 };

            return numbers;
        }

        public static string returnStringTest(string name)
        {
            string resultName = $"Hi, {name}";
            return resultName;
        }
        //array length = 10
        public static int[] SortAlgorithm(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j+1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
