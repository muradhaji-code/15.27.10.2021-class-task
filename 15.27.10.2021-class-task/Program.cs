using System;

namespace _15._27._10._2021_class_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("1, 2, 3 => " + SumOf3(1, 2, 3));
            Console.WriteLine("1, 3, 2 => " + SumOf3(1, 3, 2));
            Console.WriteLine("3, 1, 2 => " + SumOf3(3, 1, 2));
            #endregion
        }

        static int SumOf3(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b > c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }
    }
}
