namespace Lesson08_for练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环练习题");
            #region 练习题一
            //输出1到100之间的整数（包含本身）
            //for(int i = 1; i <= 100; ++i)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 练习题二
            //求1~100之间所有偶数的和
            //int sum = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if( i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 练习题三
            //找出100~999之间的水仙花数
            //例如：153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3 这个数就是水仙花数

            //int num = 999;
            ////int num = int.Parse(Console.ReadLine());
            ////int n = num.ToString().Length;
            //int a = 0;
            //int b = 0;
            //int c = 0;
            //for (int i = 100; i < num; i++)
            //{
            //    a = i / 100;
            //    b = i % 100 / 10;
            //    c = i % 10;
            //    if (i == (a * a * a + b * b * b + c * c * c))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region 练习题四
            //在控制台上输出九九乘法表

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write("{0} * {1} = {2}", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 练习题五
            //在控制台上输出如下10 * 10的空心星型方阵
            //**********
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //**********
            //行
            //for (int j = 0; j < 10; j++)
            //{
            //    //列
            //    for (int i = 0; i < 10; i++)
            //    {
            //        //列 如果是 第1行和最后1行 那么 内层列循环 都打印星号
            //        // 按照 **********的规则打印
            //        if( j == 0 || j == 9 )
            //        {
            //            Console.Write("*");
            //        }
            //        //否则 就是 按照*         *的规则打印
            //        else
            //        {
            //            if (i == 0 || i == 9)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region 练习题六
            //在控制台上输出如下10 * 10的三角形方阵
            //*       1   1
            //**      2   2
            //***     3   3
            //****    4   4
            //*****
            //******
            //*******
            //********
            //*********
            //**********
            //行

            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = i; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 练习题七
            //在控制台上输出如下10行的三角形方阵
            //         *            1    1   -> 2i - 1    9    10 - i
            //        ***           2    3   -> 2i - 1    8    10 - i
            //       *****          3    5                7    10 - i
            //      *******         4    7                6    10 - i
            //     *********        5    9                5
            //    ***********       6    11               4
            //   *************      7    13               3
            //  ***************     8    15               2
            // *****************    9    17               1
            //*******************   10   19               0    10 - i
            //行

            for (int i = 1; i <= 10; i++)
            {
                // 打印空格
                for (int j = 1; j <= 10-i; j++)
                {
                    Console.Write(" ");
                }

                // 打印**
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            #endregion
        }
    }
}
