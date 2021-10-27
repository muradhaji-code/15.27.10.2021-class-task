using System;

namespace _15._27._10._2021_class_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine("max(1, 2, 3) = " + MaxOf3(1, 2, 3));
            //Console.WriteLine("max(1, 3, 2) = " + MaxOf3(1, 3, 2));
            //Console.WriteLine("max(3, 1, 2) = " + MaxOf3(3, 1, 2));
            #endregion

            #region Task 2
            //MySwap(5, 7);
            #endregion

            #region Task 3
            Console.WriteLine("Sum of digits of 12345: " + SumOfDigits(12345));
            #endregion
        }

        static int MaxOf3(int a, int b, int c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);
            #region alternative 1
            //if (a > b)
            //{
            //    if (a > c)
            //    {
            //        return a;
            //    }
            //    else
            //    {
            //        return c;
            //    }
            //}
            //else
            //{
            //    if (b > c)
            //    {
            //        return b;
            //    }
            //    else
            //    {
            //        return c;
            //    }
            //}
            #endregion
        }

        static void MySwap(int a, int b)
        {
            Console.WriteLine($"Now the 1st number is {(a > b ? a : b)}, and the 2nd number is {(a < b ? a : b)}");
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
