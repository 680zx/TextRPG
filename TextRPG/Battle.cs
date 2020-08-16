using DeflectTheBall;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextRPG
{
    class Battle
    {
        private static int BattleExperience = 100;
        public static void Run(Player player)
        {        
            Monster monster = Utilities.GetMonster(player);
            Window.BattleScreen(player, monster);
            //Console.WriteLine(player.Name);
            while (! (player.isDead || monster.isDead))
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        player.Hit(monster);
                        Thread.Sleep(1000);
                        monster.Hit(player);
                        Thread.Sleep(1000);
                        Window.BattleScreen(player, monster);
                        
                        break;

                    case '2':
                        player.RestoreHealth();
                        Thread.Sleep(1000);
                        Window.BattleScreen(player, monster);
                        //monster.Hit(player);
                        break;
                }
            }

            if (!player.isDead) 
                if(player.CurrentExperience + BattleExperience >= player.ExperienceToUp)
                {
                    player.Level++;
                    player.CurrentExperience = 0;
                    Window.LevelUpScreen(player);
                    Thread.Sleep(2000);
                }
                else
                {
                    player.CurrentExperience += BattleExperience;
                    Window.EndBattleScreen(monster);
                    Thread.Sleep(2000);
                }
            else
                Window.GameOverScreen();

        }

        /*
        public static Monster GetMonster(Player player)
        {
            foreach (Monster monster in Utilities.GetMonster())
                if (monster.Level == player.Level)
                    return monster;
          
            return null;
        }
        */
    }
}
