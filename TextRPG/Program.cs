using DeflectTheBall;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
                player = new Player(LittleVilla, Utilities.CommonQualityMeleeWeapons[1]);
                
                Window.CreationScreen();
                //player.SetName();
                //player.ChooseRace();
                player.Name = "TestPlayer";
                player.Race = "TestPlayer";
                //player.Inventory.Add(Utilities.CommonQualityMeleeWeapons[0]);
                player.Inventory.Add(Utilities.CommonQualityPotions[1]);
                player.Inventory.Add(Utilities.CommonQualityPotions[1]);
                player.Inventory.Show();
                //Thread.Sleep(2000);

                while (! player.isDead)
                {
                    Window.VillageScreen(LittleVilla, player);

                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            Battle.Run(player);
                            break;
                    }
                }
                Window.GameOverScreen();
                Thread.Sleep(1000);
                Window.GameMenu();
               
            }
            //Console.ReadKey();

        }
    }
}
