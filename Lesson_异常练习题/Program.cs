namespace Lesson_day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获练习题！");

            #region   练习一
            // 请用户输入一个数字
            // 如果用户输入有误，则提示输入错误
            //Console.WriteLine("请输入一个数字");
            //try
            //{
            //    string str = Console.ReadLine();    
            //    int i = int.Parse(str);
            //    Console.WriteLine("输入的数字是：" + i);   
            //}
            //catch 
            //{

            //    Console.WriteLine("输入的不是一个数字！");
            //}
            #endregion

            #region 练习二
            //提示用户输入姓名、语文、数学、英语成绩
            //如果用户输入成绩有误，则提示用户输入错误
            //否则将输入的字符串转换成整形存储

            try
            {
                Console.WriteLine("请输入名字：");
                string name = Console.ReadLine();
                Console.WriteLine("请输入语文成绩：");
                string chinese = Console.ReadLine();
                int c = int.Parse(chinese); 
                Console.WriteLine("请输入数学成绩：");
                string maths = Console.ReadLine();
                int m = int.Parse(maths);   
                Console.WriteLine("请输入英语成绩：");
                string english = Console.ReadLine();
                int en = int.Parse(english);
                Console.WriteLine("姓名：{0}，语文成绩：{1}，数学成绩：{2}，英语成绩：{3}",name,c,m,en);
            }
            catch 
            {

                Console.WriteLine("成绩输入有误"); 
            }

            #endregion

        }

    }
}
