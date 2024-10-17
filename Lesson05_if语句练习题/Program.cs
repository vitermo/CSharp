using System.Security.Cryptography;

namespace Lesson05_if语句练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 练习题一
            //请用户输入今日看唐老狮视频花了多少分钟，如果大于60分钟，
            //那么在控制台输出“今天看视频花了XX分钟，看来你离成功又进了一步!”
            // 控制台输入  类型转换  异常捕获  条件运算符  if语句

            //try
            //{
            //    Console.WriteLine("看视频时间");
            //    string str = Console.ReadLine();
            //    int time = int.Parse(str);
            //    if (time > 60)
            //    {
            //        Console.WriteLine("离成功更近一步");
            //    }
            //    else {
            //        Console.WriteLine("需要努力");
            //    }
            //}
            //catch 
            //{

            //    Console.WriteLine("输入不合法");
            //}

            #endregion

            #region 练习题二
            //请输入你的 语文，数学，英语成绩，满足以下任意条件，则输出“非常棒，继续加油”
            //语文成绩大于70 并且 数学成绩大于80 并且英语成绩大于90
            //语文成绩等于100或者数学成绩等于100或者英语成绩等于100
            //语文成绩大于90 并且 其它两门中有一门成绩大于70
            // 控制台输入 类型转换 异常捕获  条件运算符 逻辑运算符  if语句

            //try
            //{
            //    Console.WriteLine("请输入语文、数学、英语成绩");
            //    string yu = Console.ReadLine();
            //    string math = Console.ReadLine();
            //    string english = Console.ReadLine();

            //    int yu1 = int.Parse(yu);
            //    int math1 = int.Parse(math);
            //    int english1 = int.Parse(english);

            //    if (yu1 > 70 && math1 > 80 && english1 > 80)
            //    {
            //        Console.WriteLine("非常棒，继续加油！");
            //    }
            //    else if (yu1 == 100 || math1 == 100 || english1 == 100)
            //    {
            //        Console.WriteLine("非常棒，继续加油！");
            //    }
            //    else if(yu1 > 90 && (math1 > 70 || english1 > 70))
            //    {
            //        Console.WriteLine("非常棒，继续加油！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("完蛋玩意");
            //    }
            //}
            //catch 
            //{

            //    Console.WriteLine("输入不合法");
            //}


            #endregion

            #region 练习题三
            //定义一个变量，存储小赵的考试成绩，如果小赵的考试成绩大于（含）90分，
            //那么爸爸奖励100元钱，否则一个月不能玩游戏

            //try
            //{
            //    Console.WriteLine("成绩");
            //    string str = Console.ReadLine();
            //    int score = int.Parse(str);
            //    if (score >= 90)
            //    {
            //        Console.WriteLine("赏你100块");
            //    }
            //    else
            //    {
            //        Console.WriteLine("完蛋玩意");
            //    }
            //}
            //catch 
            //{

            //    Console.WriteLine("输入不合法");
            //}

            #endregion

            #region 练习题四
            //要求用户输入两个数a、b，如果两个数可以整除或者这两个数加起来大于100，
            //则输出a的值，否则输出b的值
            // 控制台输入 类型转换  异常捕获  算数运算符  条件运算符  逻辑运算符
            // if else 语句

            //try
            //{
            //    Console.WriteLine("请输入两个数字：");
            //    string str1 = Console.ReadLine();
            //    string str2 = Console.ReadLine();
            //    int num = int.Parse(str1);
            //    int num2 = int.Parse(str2);
            //    bool c1 = num % num2 == 0 || num2 % num == 0;
            //    bool c2 = num + num2 > 100;
            //    if (c1 || c2)
            //    {
            //        Console.WriteLine(num);
            //    }
            //    else
            //    {
            //        Console.WriteLine(num2);
            //    }
            //}
            //catch 
            //{

            //    Console.WriteLine("输入不合法");
            //}


            #endregion

            #region 练习题五
            //输入一个整数，如果这个数是偶数，则打印“Your input is even”，否则打印“Your input is odd”
            // 控制台输入 类型转换 异常捕获  条件运算符  if语句  算术运算符

            //try
            //{
            //    Console.WriteLine("请输入一个整数");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("Your input is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your input is odd");
            //    }

            //}
            //catch 
            //{

            //    Console.WriteLine("输入不合法");
            //}
            #endregion

            #region 练习题六
            //有3个整形变量，分别存储不同的值，编写代码输出其中最大的整数
            // 条件运算符 逻辑运算符 if else if else 语句

            //try
            //{
            //    //int a = 10, b = 20, c = 30;
            //    Console.WriteLine("请输入三个数字");
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    int c = int.Parse(Console.ReadLine());

            //    int big = a > b ? a : b;
            //    int big1 = b > c ? b : c;
            //    int max = big > big1 ? big : big1;

            //    Console.WriteLine(max);

            //}
            //catch 
            //{

            //    Console.WriteLine("输入不合法");
            //}
            #endregion

            #region 练习题七
            //写一个程序接受用户输入的字符，如果输入的字符是0~9数字中的一个，
            //则显示“您输入了一个数字”，否则显示这不是一个数字
            // 控制台输入 类型转换 异常捕获 条件运算符 逻辑运算符 if语句

            //try
            //{
            //    Console.WriteLine("请输入一个0~9其中的一个数字");

            //    int num = Console.ReadKey().KeyChar; //获取askii 阿斯克码
            //    if (num >= '0' && num <= '9')
            //    {
            //        Console.WriteLine("你输入了一个数字");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是0-9之间的数");
            //    }
            //}
            //catch 
            //{

            //    Console.WriteLine("不是数");
            //}

            #endregion

            #region 练习题八
            //提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”，
            //并且密码是"8888"，则提示正确，否则，
            //如果用户名不是admin还提示用户用户名不存在，如果用户名是admin则提示密码错误
            // if嵌套使用 

            //Console.WriteLine("请输入用户名");
            //string  name = Console.ReadLine();

            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();

            //if (name.Equals("admin") && pwd.Equals("8888"))
            //{
            //    Console.WriteLine("登陆成功");
            //}
            //if (name != "admin")
            //{
            //    Console.WriteLine("用户名错误");
            //}
            //else {
            //    Console.WriteLine("密码错误");
            //}

            #endregion

            #region 练习题九
            //提示用户输入年龄，如果大于等于18，则告知用户可以查看，
            //如果小于13岁，则告知不允许查看，如果大于等于13并且小于18，
            //则提示用户是否继续查看（yes、no），
            //如果输入的是yes则提示用户请查看，否则提示“退出”。
            // if else if else  嵌套使用 

            //try
            //{
            //    Console.WriteLine("要不要看色色，先输入年纪");
            //    int age = int.Parse(Console.ReadLine());
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("可以看色色");
            //    }
            //    else if (13 <= age && age <= 18)
            //    {
            //        Console.WriteLine("确定要看色色？");
            //        Console.WriteLine("Yes or No");
            //        string confirm = Console.ReadLine();
            //        if (confirm == "Yes" || confirm == "yes")
            //        {
            //            Console.WriteLine("好吧，悄悄的看，别被爸妈抓住了哦");
            //        }
            //        else
            //        {
            //            Console.WriteLine("好孩子，咱们不看色色哈");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("你还小，不能看色色");
            //    }
            //}
            //catch 
            //{

            //    Console.WriteLine("我要的是年纪，你还想不想看色色了,不想看滚");
            //}

            #endregion

            #region 练习题十
            //请说明以下代码的打印结果（不要打一遍代码，请直接通过阅读说出结果）

            // 语句块 会影响 变量的 生命周期

            //函数语句块 目前我们学习知识时  是层级最高的语句块

            //int a = 1;
            ////int b = 2;
            //{
            //    int b = 3;
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //}
            //Console.WriteLine(b);

            //int a = 5;
            //if (a > 3)
            //{
            //    int b = 0;
            //    ++b;
            //    b += a;
            //}
            //Console.WriteLine(b);
            #endregion
        }
    }
}
