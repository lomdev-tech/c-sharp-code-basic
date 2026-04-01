using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Game1
    {
        static void aa(string[] args) {
            //初始化血量
            int hero = 10;
            int monster = 10;

            Random randow = new();
            //游戏循环至少进行一次攻击
            do {
                //英雄攻击怪物
                var heroDanmaged =  randow.Next(1, 11);//随机攻击1-10滴血
                monster=monster- heroDanmaged;
                Console.WriteLine($"怪物被攻击{heroDanmaged}滴血,还剩{monster}滴血");
                if (monster <= 0) continue;//如果怪物死了就不攻击了
                //怪物攻击英雄
                var monsterDanmaged = randow.Next(1, 11);//随机攻击1-10滴血
                hero = hero - monsterDanmaged;
                Console.WriteLine($"英雄被攻击{monsterDanmaged}滴血,还剩{hero}滴血");
            } while (hero > 0 && monster > 0);
            Console.WriteLine((hero>monster)?"英雄赢!":"怪物赢!");
        }
    }
}
