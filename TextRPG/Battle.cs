using DeflectTheBall;
using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    class Battle
    {
        public static void Run(Player player)
        {        
            Monster monster = Utilities.GetMonster(player);
            Window.BattleScreen(player, monster);
            Console.WriteLine(player.Name);
            while (! (player.isDead || monster.isDead))
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        player.Hit(monster);
                        monster.Hit(player);
                        Window.BattleScreen(player, monster);
                        Console.Write($"\n\n\t" + player.Name + " hit " + monster.Race + 
                            " level " + monster.Level + " and did " + player._weapon.Power + " damage" +
                            "\n\t" + monster.Race + " level " + monster.Level +   " hit " + player.Name +
                            " and did " + monster._weapon.Power + " damage" +
                            $"\n\n\n\t{player.Name} health: {player.CurrentHealth}" +
                            $"\t{monster.Race} health: {monster.CurrentHealth}");
                        break;

                    case '2':
                        Window.BattleScreen(player, monster);
                        player.RestoreHealth();
                        //monster.Hit(player);
                        break;

                    case '3':
                        player.Inventory.Show();
                        break;
                }
            } 
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
