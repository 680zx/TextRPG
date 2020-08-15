using DeflectTheBall;
using System;
using System.Collections.Generic;
using System.Threading;

namespace TextRPG
{
    class Program
    {

        static void Main(string[] args)
        {
            Window.Width = 70;
            Window.Height = 30;
            //Window.GameMenu();
            Console.CursorVisible = false;

            Village LittleVilla = new Village("Little Villa", 143, Utilities.VillageTraders);
            City RedCastle = new City("Red Castle", 572, Utilities.CityTraders);

            Player player;//= new Player(LittleVilla, Utilities.GetCommonQualityMeleeWeapons()[2], Utilities.GetCommonQualityPotions()[3]);
            //Monster Orc = new Monster("Uruglah", "Orc", "Legendary", 150, Utilities.CommonQualityMeleeWeapons[0]);
            /*
            Console.WriteLine($"Now you are in {Player.CurrentLocation.Name}");

            Player.MoveTo(RedCastle);
            Console.WriteLine(Player.Inventory.MaxVolume + "\n\n" + Player.Inventory.FilledVolume);

            Player.Inventory.Add(Utilities.GetCommonQualityPotions()[4]);
            Player.Inventory.Show();
            */
            //Window.CityScreen(RedCastle, Player);
            //Window.TradeScreen(LittleVilla.Traders[1], Player);
            //Window.BattleScreen(Player, Orc);
            //Console.ReadKey();

            Window.GameMenu();
            while(Console.ReadKey().KeyChar != '3')
            {
                Window.CreationScreen();
                player = new Player(LittleVilla);


                while (! player.isDead)
                {
                    player.SetName();
                    player.ChooseRace();
                    player.Inventory.Add(Utilities.CommonQualityMeleeWeapons[0]);

                    Thread.Sleep(1000);

                    Window.VillageScreen(LittleVilla, player);

                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            Utilities.Battle(player, Utilities.monsters[0]);
                            Thread.Sleep(1000);
                            break;
                    }
                }
                
            }
            //Console.ReadKey();

        }
    }
}
