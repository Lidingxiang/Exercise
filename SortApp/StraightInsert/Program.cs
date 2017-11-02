using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraightInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7, 6, 5, 4 };

            GetSort(arr);

            Console.Read();
        }

        private static int[] GetSort(int[] arr)
        {
            int tmp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    var aa1 = arr[i - 1];
                    var aa2 = arr[i];

                    tmp = arr[i];

                    int j = i;
                    while (j > 0 && arr[j - 1] > tmp)
                    {
                        var dd1 = arr[j];
                        var dd2 = arr[j - 1];
                        dd1 = dd2;

                        arr[j] = arr[j - 1];
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
