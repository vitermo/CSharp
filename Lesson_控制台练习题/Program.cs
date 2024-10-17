namespace Lesson_控制台练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("控制台相关练习题");

            //修改窗口标题
            Console.Title = "小游戏";

            //改背景颜色
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            //改变字体颜色
            Console.ForegroundColor = ConsoleColor.Red;
            //隐藏光标
            Console.CursorVisible = false;

            //设置窗口大小
            Console.SetWindowSize(50,20);
            //设置缓冲区大小
            Console.SetBufferSize(50,20);

            //黄色方块感觉像人一样 这个人身上有位置信息
            // x y

            int x = 0;
            int y = 0;

            //不停的输入 wasd键 都可以控制它移动
            //根据不停 就分析 用while循环是最简单的一种方式

            while (true)
            {
                //Console.Clear();   第一种清空之前信息的方式，闪烁，容易丢
                Console.SetCursorPosition(x,y);
                Console.Write("■");

                char c = Console.ReadKey(true).KeyChar;
                //第二种清空之前信息的方式
                Console.SetCursorPosition(x,y);
                Console.Write("  ");
                switch (c)
                {
                    case 'W':
                    case 'w':
                        y -= 1;
                        if (y < 0 ) {
                            y = 0;
                        }
                        break;
                    case 'A':
                    case 'a':
                        x -= 2;
                        if ( x < 0) {
                            x = 0;
                        }
                        break;
                    case 'S':
                    case 's':
                        y += 1;
                        if (y > 19) {
                            y = 19;
                        }
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if ( x > 49) {
                            x = 49;
                        }
                        break;

                }
            }

        }
    }
}
