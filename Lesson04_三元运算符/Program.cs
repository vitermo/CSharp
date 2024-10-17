namespace Lesson04_三元运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三元运算符练习题");
            #region 练习一
            //比较两个数的大小，求出最大的

            //Console.WriteLine("请输入第一个数字");
            //string str = Console.ReadLine();    
            //Console.WriteLine("请输入第二个数字");
            //string str1 = Console.ReadLine();   
            //int num1 = int.Parse(str1); 
            //int num = int.Parse(str);

            //string str2 = num >= num1 ? "较大的数字是第一个：" + num  : "较大的数字是第二个：" + num1;
            //Console.WriteLine(str2);    
            #endregion

            #region 练习二
            //提示用户输入一个姓名，然后控制台输出，
            //只要输入的不是帅哥，就显示美女

            //Console.WriteLine("请输入一个姓名：");
            //string name = Console.ReadLine();
            //string str = name == "帅哥" ? name : "美女";  //如果name=帅哥，那么就输出name，如果不等于就输出美女
            //Console.WriteLine(str);
            #endregion

            #region 练习三
            //依次输入学生的成绩，C#、unity都大于或等于90才能毕业，输出结果

            //Console.WriteLine("请依次输入学生成绩，C#、unity");
            //string str_1 = Console.ReadLine();
            //string str_2 = Console.ReadLine();
            //int num = int.Parse(str_1);
            //int num2 = int.Parse(str_2);  
            //string str_3 = (num >= 90 && num2 >= 90) ? "毕业" : "不毕业";
            //Console.WriteLine(str_3);
            #endregion

            #region 练习四
            //要求用户输入一个年份，然后判断是不是闰年？
            //闰年判断条件：年份能被400整除，
            //或者年份能被4整除，但是不能被100整除

            try
            {
                Console.WriteLine("请输入一个年份：");
                string str = Console.ReadLine();
                int year = int.Parse(str);
                string result = year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? "闰年" : "平年";
                Console.WriteLine(result);
            }
            catch
            {

                Console.WriteLine("输入不合法！");
            }
            #endregion
        }
    }
}
