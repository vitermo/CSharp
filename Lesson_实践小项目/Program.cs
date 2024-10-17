namespace Lesson_实践小项目
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("小游戏");
            #region 控制台基础设置

            //设置标题
            Console.Title = "营救公主";

            //隐藏光标
            Console.CursorVisible = false;

            int w = 50;
            int h = 30;

            //设置窗口大小
            Console.SetWindowSize(w, h);
            //设置缓存区大小
            Console.SetBufferSize(w, h);

            #endregion

            #region 多场景切换

            //定义场景编号
            int nowSceneID = 1;

            //是否找到公主
            bool find = false;

            while (true)
            {
                switch (nowSceneID)
                {
                    //开始场景
                    case 1:
                        #region 开始场景                        
                        Console.Clear();
                        //Console.WriteLine("开始场景");
                        Console.SetCursorPosition(w / 2 - 7, 5);
                        Console.WriteLine("营救公主小游戏");


                        //因为要有输入，所以我们可以构造一个开始场景的死循环
                        //专门用来处理开始界面的相关逻辑

                        //定义当前选择的编号
                        int nowSelIndex = 0;

                        while (true)
                        {
                            //用一个标识，来处理在while循环内部的Switch逻辑执行时，想要退出外层的while循环
                            //改编标识即可
                            bool isQuitWhile = false;
                            //显示内容
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(w / 2 - 4, 7);
                            Console.WriteLine("开始游戏");

                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(w / 2 - 4, 9);
                            Console.WriteLine("退出游戏");

                            //检测输入
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    nowSelIndex--;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    nowSelIndex++;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        //切换游戏场景
                                        nowSceneID = 2;
                                        //退出内层while循环
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }

                            if (isQuitWhile)
                            {
                                break;
                            }

                        }

                        #endregion
                        break;
                    //游戏场景
                    case 2:

                        Console.Clear();
                        #region 不变的红墙
                        //设置颜色为红色
                        Console.ForegroundColor = ConsoleColor.Red;
                        //上方墙
                        for (int i = 0; i < w; i += 2)
                        {
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");

                            //中间墙
                            Console.SetCursorPosition(i, h - 10);
                            Console.Write("■");

                            //下方墙
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");


                        }
                        ////中间墙
                        //for (int i = 0; i < w; i += 2)
                        //{
                        //    Console.SetCursorPosition(i, h - 10);
                        //    Console.Write("■");
                        //}

                        ////下方墙
                        //for (int i = 0; i < w; i += 2)
                        //{
                        //    Console.SetCursorPosition(i, h - 1);
                        //    Console.Write("■");
                        //}

                        //左边墙
                        for (int i = 0; i < h; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");


                            //右边墙
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }

                        ////右边墙
                        //for (int i = 0; i < h; i++)
                        //{
                        //    Console.SetCursorPosition(w - 2, i);
                        //    Console.Write("■");
                        //}

                        #endregion

                        #region BOSS相关属性设置

                        int bossX = 24;
                        int bossY = 15;
                        int BossATKMin = 7;
                        int BossATKMax = 14;
                        int BossHp = 200;
                        string BossIcon = "★";
                        //申明一个颜色变量
                        ConsoleColor bosscolor = ConsoleColor.Green;

                        #endregion

                        #region 玩家属性相关

                        int playX = 4;
                        int playY = 5;
                        int playAtkMin = 7;
                        int playAtkMax = 10;
                        int playHp = 200;
                        string playIcon = "●";
                        ConsoleColor playcolor = ConsoleColor.White;
                        //定义玩家输入，节约资源
                        char playInput;

                        #endregion

                        #region 公主相关

                        int princessX = 24;
                        int princessY = 5;
                        string princessIcon = "▲";
                        ConsoleColor princessColor = ConsoleColor.Blue;
                           
                        #endregion

                        #region 玩家战斗相关
                        //战斗状态标识
                        bool isFight = false;
                        //作用是从while循环里的Switch改变标识，用来跳出外层的while循环
                        bool isOver = false;
                        #endregion

                        while (true)
                        {
                            #region Boss相关
                            if (BossHp > 0)
                            {
                                //绘制BOSS图标
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bosscolor;
                                Console.Write(BossIcon);
                            }
                            #endregion

                            #region 公主相关
                            else {
                                Console.SetCursorPosition(princessX, princessY);
                                Console.ForegroundColor = princessColor;
                                Console.Write(princessIcon);
                            }
                            #endregion


                            //绘制玩家 
                            Console.SetCursorPosition(playX, playY);
                            Console.ForegroundColor = playcolor;
                            Console.Write(playIcon);

                            playInput = Console.ReadKey(true).KeyChar;

                            //战斗状态处理逻辑
                            if (isFight)
                            {

                                #region 玩家战斗逻辑

                                if (playInput == 'J' || playInput == 'j')
                                {
                                    //在这判断玩家或者BOSS死亡
                                    if (playHp <= 0)
                                    {
                                        //游戏结束
                                        nowSceneID = 3;
                                        isOver = true;
                                        
                                    }
                                    else if (BossHp <= 0)
                                    {
                                        //去营救公主
                                        

                                        //Boss擦除
                                        Console.SetCursorPosition(bossX, bossY);
                                        Console.Write("  ");
                                        isFight = false;
                                        find = true;
                                    }
                                    else
                                    {
                                        //按J键打架逻辑
                                        //玩家打BOSS
                                        //获得玩家攻击力
                                        Random random = new Random();
                                        int atk = random.Next(playAtkMin, playAtkMax);
                                        BossHp -= atk;
                                        //打印信息
                                        Console.ForegroundColor = ConsoleColor.White;
                                        //擦出原有信息
                                        Console.SetCursorPosition(2, h - 8);
                                        Console.Write("                                   ");
                                        //打印新信息
                                        Console.SetCursorPosition(2, h - 8);
                                        Console.Write("玩家造成了{0}点伤害，Boss血量剩余{1}", atk, BossHp);

                                        if (BossHp > 0)
                                        {
                                            //BOSS打玩家
                                            //获取BOSS攻击力
                                            atk = random.Next(BossATKMin, BossATKMax);
                                            playHp -= atk;
                                            //打印信息
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            //擦出原有信息
                                            Console.SetCursorPosition(2, h - 7);
                                            Console.Write("                                             ");
                                            //打印新信息

                                            //boss把玩家打死了
                                            if (playHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, h - 8);
                                                Console.Write("很遗憾，你被BOSS打死了，没法营救公主！");
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, h - 7);
                                                Console.Write("Boss造成了{0}点伤害，玩家血量剩余{1}", atk, playHp);
                                            }
                                        }
                                        else
                                        {
                                            //擦除之前的战斗信息
                                            Console.SetCursorPosition(2, h - 9);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 8);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 7);
                                            Console.Write("                                             ");

                                            //打印赢了之后的信息
                                            Console.SetCursorPosition(2, h - 9);
                                            Console.Write("你打赢了BOSS！");
                                            Console.SetCursorPosition(2, h - 8);
                                            Console.Write("快去营救公主！");
                                            Console.SetCursorPosition(2, h - 7);
                                            Console.Write("按J键继续");
                                        }
                                    }
                                }
                                #endregion
                            }

                            //非战斗状态处理逻辑
                            else
                            {

                                #region 玩家移动相关
                                //擦除
                                Console.SetCursorPosition(playX, playY);
                                Console.Write("  ");

                                //改位置
                                switch (playInput)
                                {
                                    case 'W':
                                    case 'w':
                                        playY--;
                                        if (playY < 1)
                                        {
                                            playY = 1;
                                        }

                                        //判断玩家的坐标是否和BOSS坐标一致，避免重合
                                        else if (playX == bossX && playY == bossY && BossHp > 0)
                                        {
                                            playY++;
                                        }
                                        else if (playX == princessX && playY == princessY && BossHp <= 0) {
                                            playY++;
                                        }
                                        break;
                                    case 'A':
                                    case 'a':
                                        playX -= 2;
                                        if (playX < 2) playX = 2;
                                        else if (playX == bossX && playY == bossY && BossHp > 0) playX += 2;
                                        else if (playX == princessX && playY == princessY && BossHp <= 0) playX += 2;                                                                                                                  
                                        break;
                                    case 'S':
                                    case 's':
                                        playY++;
                                        if (playY > h - 11) playY = h - 11;
                                        else if (playX == bossX && playY == bossY && BossHp > 0) playY--;
                                        else if (playX == princessX && playY == princessY && BossHp <= 0) playY--;
                                        //{
                                        //    playY++;
                                        //}
                                        break;
                                    case 'D':
                                    case 'd':
                                        playX += 2;
                                        if (playX > w - 4) playX = w - 4;
                                        else if (playX == bossX && playY == bossY && BossHp > 0) playX -= 2;
                                        else if (playX == princessX && playY == princessY && BossHp <= 0) playX -= 2;
                                        //{
                                        //    playY++;
                                        //}
                                        break;
                                    #region 战斗逻辑
                                    case 'J':
                                    case 'j':

                                        //开始战斗
                                        if ((playX == bossX && playY == bossY - 1 ||
                                            playX == bossX && playY == bossY + 1 ||
                                            playX == bossX - 2 && playY == bossY ||
                                            playX == bossX + 2 && playY == bossY) && BossHp > 0)
                                        {
                                            isFight = true;

                                            //可以开始战斗
                                            Console.SetCursorPosition(2, h - 9);
                                            Console.Write("开始和BOSS战斗，按J键继续");
                                            Console.SetCursorPosition(2, h - 8);
                                            Console.Write("BOSS当前血量：{0}", BossHp);
                                            Console.SetCursorPosition(2, h - 7);
                                            Console.Write("玩家当前血量：{0}", playHp);

                                        }

                                        //判读是否在公主身边按下J键
                                        else if((playX == princessX  && playY == princessY - 1 ||
                                            playX == princessX && playY == princessY + 1 ||
                                            playX == princessX - 2 && playY == princessY ||
                                            playX == princessX + 2 && playY == princessY) && BossHp <= 0)
                                        {
                                            //改变场景ID
                                            nowSceneID = 3;
                                            //跳出游戏场景循环，回到主循环
                                            isOver = true;
                                            break;
                                        }
                                        break;
                                        #endregion
                                }
                                #endregion
                            }
                            //外层的while循环
                            if (isOver) {
                                //和游戏场景主循环while循环配对
                                break;
                            }
                        }
                        break;
                    //结束场景
                    case 3:
                        #region 结束界面

                        
                        Console.Clear();
                        //Console.WriteLine("结束场景");

                        if (find)
                        {
                            Console.SetCursorPosition(w / 2 - 4, 5);
                            Console.WriteLine("Game Over");
                            Console.SetCursorPosition(w / 2 - 4, 6);
                            Console.WriteLine("英雄救美");
                        }
                        else
                        {
                            Console.SetCursorPosition(w / 2 - 4, 5);
                            Console.WriteLine("Game Over");
                            Console.SetCursorPosition(w / 2 - 11, 6);
                            Console.WriteLine("小菜鸡，公主还等着你呢");
                        }
                        //Console.SetCursorPosition(w / 2 - 7, 5);
                        //Console.WriteLine("营救公主小游戏");


                        //因为要有输入，所以我们可以构造一个开始场景的死循环
                        //专门用来处理开始界面的相关逻辑

                        //定义当前选择的编号
                        int nowOverIndex = 0;
                        while (true)
                        {
                            //用一个标识，来处理在while循环内部的Switch逻辑执行时，想要退出外层的while循环
                            //改编标识即可
                            bool isQuitWhile = false;
                            //显示内容
                            Console.ForegroundColor = nowOverIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(w / 2 - 4, 7);
                            Console.WriteLine("继续游戏");

                            Console.ForegroundColor = nowOverIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(w / 2 - 4, 9);
                            Console.WriteLine("退出游戏");

                            //检测输入
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    nowOverIndex--;
                                    if (nowOverIndex < 0)
                                    {
                                        nowOverIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    nowOverIndex++;
                                    if (nowOverIndex > 1)
                                    {
                                        nowOverIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowOverIndex == 0)
                                    {
                                        //切换游戏场景
                                        nowSceneID = 1;
                                        //退出内层while循环
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitWhile)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                }
            }

            #endregion


        }
    }
}
