namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*第一步 输入y或n 开始游戏 
             * 第二步 系统随机生一个1-5之间的目标数  1-6之间是随机数 
             *第三步  让他们比较大小
             *第四步 出结果
             *
             */

            Random random = new();

            Console.WriteLine("你想开始玩抛骰子游戏吗?(y/n)");
            if (startGame())
            {

                playGame();


            }
            bool startGame()
            {
                var readRusult = Console.ReadLine();
                return readRusult.ToLower().Equals("y");
            }

            void playGame()
            {
                bool flag = true;
                while (flag)
                {
                    Console.Clear();

                    int target = getTargetNum();
                    int rollDice = getRollDiceNum();
                    Console.WriteLine($"生成的随机数比目标数{target}大就赢");
                    Console.WriteLine($"生成的随机数为{rollDice}");
                    Console.WriteLine(WinOrLose(rollDice, target));
                    Console.WriteLine("想继续玩吗?(y/n)");
                    flag = startGame();

                }


            }
            int getTargetNum()
            {


                return random.Next(1, 6);
            }
            int getRollDiceNum()
            {


                return random.Next(1, 7);
            }

            string WinOrLose(int rollDice, int target)
            {


                if (rollDice > target)
                {

                    return "你赢了";
                }

                return "你输了";
            }

        }
    }
}
