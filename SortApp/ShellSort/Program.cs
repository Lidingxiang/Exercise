using System;

namespace ShellSort
{

    public class MainClass
    {
        public static void Main()
        {
            int[] a = { 49, 38, 65, 97, 26, 13, 27, 49, 55, 4 };
            shellsort1(a, a.Length);           //希尔插入排序  
            Console.Read();
        }


        static void shellsort1(int[] a, int n)
        {
            for (int gap = n / 2; gap > 0; gap /= 2) //步长  
            {
                for (int i = 0; i < gap; i++)        //直接插入排序  
                {
                    for (int j = i + gap; j < n; j += gap)
                    {
                        if (a[j] < a[j - gap])
                        {
                            int temp = a[j];
                            int k = j - gap;
                            while (k >= 0 && a[k] > temp)
                            {
                                a[k + gap] = a[k];
                                k -= gap;
                            }
                            a[k + gap] = temp;
                        }
                    }
                    PrintArr(a, i);
                }
            }
        }

        private static void PrintArr(int[] arr, int j)
        {
            Console.Write("第{0}次排序：", j);
            foreach (var i in arr)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }
    }
}

