namespace Lesson06_switch练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch练习题");
            #region 练习题一
            //唐老狮的工资是由基本工资 + 绩效决定的
            //绩效说明：
            //学生评价 很兴奋，则评定为A级，绩效工资500
            //学生评价 很充实，则评定为B级，不加绩效工资
            //学生评价 还好吧，则评定为C级，绩效工资扣300
            //学生评价 难理解，则评定为D级，绩效工资扣500
            //学生评价 枯燥泛味，则评定为E级，绩效工资扣800

            //假设唐老狮的工资是4000
            //请用户输入唐老师的评级，并算出唐老师的工资是多少？

            //int salary = 4000;
            //int money = 0;
            //Console.WriteLine("请输入对唐老师的评级:A、B、C、D、E");
            //string grade = Console.ReadLine();
            //switch (grade)
            //{
            //    case "A":
            //    case "a":
            //        money = salary;
            //        break;
            //    case "B":
            //    case "b":
            //        money = salary + 500;
            //        break;
            //    case "C":
            //    case "c":
            //        money = salary - 300;
            //        break;
            //    case "D":
            //    case "d":
            //        money = salary - 500;
            //        break;
            //    case "E":
            //    case "e":
            //        money = salary - 800;
            //        break;
            //    default:
            //        Console.WriteLine("请输入正确的评级");
            //        break;
            //}
            //Console.WriteLine("唐老师的基本工资为：{0},绩效评级为：{1}，最终工资为：{2}", salary, grade, money);

            #endregion

            #region 练习题二
            //小唐带了10元钱去星巴克买咖啡，三种型号选择：
            //1 = (中杯，¥5)
            //2 = (大杯，¥7)
            //3 = (超大杯，¥11)
            //请用户输入选择的型号，如果钱够，则购买成功，并算出小王最后还剩多少钱？
            //如果钱不够，则提示用户“钱不够，请换其他型号”

            //try
            //{
            //    int money = 10;
            //    Console.WriteLine("请输入选择的型号：1号：中杯，5元，2号：大杯，7元，3号：超大杯，11元");
            //    int type = int.Parse(Console.ReadLine());
            //    switch (type)
            //    {
            //        case 1:
            //            if (money >= 5)
            //            {
            //                money -= 5;
            //                Console.WriteLine("购买成功，还剩{0}元", money);
            //            }
            //            else
            //            {
            //                Console.WriteLine("钱不够！");
            //            }
            //            break;
            //        case 2:
            //            if (money >= 7)
            //            {
            //                money -= 7;
            //                Console.WriteLine("购买成功，还剩{0}元", money);
            //            }
            //            else
            //            {
            //                Console.WriteLine("钱不够！");
            //            }
            //            break;
            //        case 3:
            //            if (money >= 11)
            //            {
            //                money -= 11;
            //                Console.WriteLine("购买成功，还剩{0}元", money);
            //            }
            //            else
            //            {
            //                Console.WriteLine("钱不够！");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("算了，不买了");
            //            break;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion

            #region 练习题三
            //输入学生的考试成绩，如果
            //成绩 >= 90：A
            //90 > 成绩 >= 80:B
            //80 > 成绩 >= 70:C
            //70 > 成绩 >= 60:D
            //成绩 < 60:E
            //（使用switch语法完成）
            //最后输出学生的考试等级

            //Console.WriteLine("输入学生的成绩");
            //int grade = int.Parse(Console.ReadLine());
            //grade /= 10;
            //switch (grade)
            //{
            //    case 10:
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    case 6: 
            //        Console.WriteLine("D");
            //        break;
            //    case 5:
            //    case 4:
            //    case 3:
            //    case 2: 
            //    case 1:
            //    case 0:
            //        Console.WriteLine("E");
            //        break;
            //}
            #endregion

            #region 练习题四
            //在控制台输入一个（0~9）的数并显示为大写。如输入2，则显示二

            try
            {
                Console.WriteLine("请输入一个0-9的数，我可以转换成大写的");
                int num = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (num)
                {
                    case 0:
                        Console.WriteLine("零");
                        break;
                    case 1:
                        Console.WriteLine("壹");
                        break;
                    case 2:
                        Console.WriteLine("贰");
                        break;
                    case 3:
                        Console.WriteLine("叁");
                        break;
                    case 4:
                        Console.WriteLine("肆");
                        break;
                    case 5:
                        Console.WriteLine("伍");
                        break;
                    case 6:
                        Console.WriteLine("陆");
                        break;
                    case 7:
                        Console.WriteLine("柒");
                        break;
                    case 8:
                        Console.WriteLine("捌");
                        break;
                    case 9:
                        Console.WriteLine("玖");
                        break;
                }
            }
            catch
            {

                Console.WriteLine("请输入正确的数字");
            }


            #endregion
        }
    }
}
