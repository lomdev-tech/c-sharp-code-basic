namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 5;          // 外部初始化为 5
                   // 先在外部定义

            if (first > 0)
            {
               int second = 6;         // 代码块内第一行：初始化 second 为 6
            }

            // 代码块后的第一行：将第二个整数值加到第一个整数的值
            first = first + second;

            // 代码块后的第二行：显示第一个整数
            Console.WriteLine(first);
        }
    }
}
