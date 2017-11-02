using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7, 6, 5, 4 };

            GetSort(arr);
        }

        private static int[] GetSort(int[] arr)
        {
            int tmp = 0;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
                Console.Write("第{0}次排序：", j);
                foreach (var i in arr)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.Read();
            return arr;
        }

    } 
}
