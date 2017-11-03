using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraightInsert
{
    public class Method1
    {
        //9,8,7,6,5,4

        public static int[] GetSort(int[] arr)
        {
            int tmp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    tmp = arr[i];

                    int j = i;
                    while (j > 0 && arr[j - 1] > tmp)
                    {
                        arr[j] = arr[j - 1];
                        j--;
                    }
                    arr[j] = tmp;
                }
                PrintArr(arr, i);
            }
            return arr;
        }

        public static int[] GetSort2(int[] arr)
        {
            int tmp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    tmp = arr[i + 1];

                    int j = i;
                    while (j > 0 && arr[j] > tmp)
                    {
                        arr[j - 1] = arr[j];
                        j--;
                    }
                    arr[j] = tmp;
                }
                PrintArr(arr, i);
            }
            return arr;
        }
         
        private static void PrintArr(int[] arr, int j)
        {
            Console.Write("第{0}次排序：", j);
            foreach (var i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
