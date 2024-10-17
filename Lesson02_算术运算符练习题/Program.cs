namespace Lesson02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算术运算符练习题");
            #region 练习一
            // 定义一个变量存储现在的年龄，十年后的年龄是多少，输出到控制台


            //try
            //{
            //    Console.WriteLine("请输入现在的年纪");
            //    string age = Console.ReadLine();
            //    int age_1 = int.Parse(age);
            //    int age_2 = age_1 + 10;
            //    Console.WriteLine("十年后的年龄：" + age_2);
            //}
            //catch 
            //{

            //    Console.Error.WriteLine("输入有误");
            //}
            #endregion

            #region 练习二
            // 计算一个半径为5的圆的面积和周长

            // 面积：PI*r^2
            // 周长：PI*2*r

            //int r = 5;
            //decimal area = 3.1415926m * r * r;
            //Console.WriteLine("半径为5的圆的面积是：" + area);
            //decimal per = 3.1415926m * r * 2;
            //Console.WriteLine("半径为5的圆的周长是：" + per);

            #endregion

            #region 练习三
            // 计算任意三门成绩的总分、平均分，打印到控制台
            // 三门成绩均为整形

            //try
            //{
            //    Console.WriteLine("请输入C#的成绩");
            //    string socre_c = Console.ReadLine();
            //    Console.WriteLine("请输入数学的成绩");
            //    string maths = Console.ReadLine();
            //    Console.WriteLine("请输入英语成绩");
            //    string english = Console.ReadLine();

            //    int soc = int.Parse(socre_c);
            //    int math = int.Parse(maths);
            //    int en = int.Parse(english);
            //    int sum = 0;
            //    float avg = 0.0f;
            //    sum = soc + math + en;
            //    avg = sum / 3;
            //    Console.WriteLine("三门成绩的总分是：{0}，平均分是：{1}",sum,avg);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("输入有误");
            //}
            #endregion

            #region 练习四
            //int a = 10, b = 20;
            //int num1 = ++a + b;
            //a = 10; b = 20;
            //int num2 = a + b++;
            //a = 10; b = 20;
            //int num3 = a++ + ++b + a++;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);

            //num1：31
            //num2：30
            //num3：42

            #endregion

            #region 练习五
            //商店T恤的价格为285元/件，裤子的价格为720元/件，小李在该店买了
            //2件T恤和3条裤子，请计算小李该付多少钱？打3.8折后呢？

            //int t = 285;
            //int tro = 720;
            //int cost = t * 2 + tro * 3;
            //float discount = (t * 2 + tro * 3) * 0.38f;
            //Console.WriteLine("2件T恤和3条裤子，小李该付：{0}，打3.8折后为：{1}",cost,discount);
            #endregion

            #region 练习六
            // 有两个数a=99,b=87，请写出两种方法交换他们的值，让a=87,b=99

            //int a = 99, b = 87;
            //int temp = 0;
            //temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region 练习七
            // 请把987652秒通过代码转为n天n小时n分钟n秒显示在控制台中

            int second = 987652;
            int day = second / (3600 * 24);
            int hour = (second - (day * 3600 * 24)) / 3600;
            int min = (second - (day * 3600 * 24) - hour * 3600) / 60;
            int sec = second - (day * 3600 * 24) - hour * 3600 - min * 60;
            Console.WriteLine("987652秒是：{0}天{1}小时{2}分钟{3}秒",day,hour,min,sec);
            #endregion
             
        }
    }
}
