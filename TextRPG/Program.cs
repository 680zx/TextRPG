using DeflectTheBall;
using System;
using System.Collections.Generic;

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

            Village LittleVilla = new Village("Little Villa", 143, Utilities.GetVillageTraders());
            City RedCastle = new City("Red Castle", 572, Utilities.GetCityTraders());

            Player Player = new Player(LittleVilla, Utilities.GetCommonQualityMeleeWeapons()[2], Utilities.GetCommonQualityPotions()[3]);
            Monster Creepy = new Monster("Uruglah", "Orc", 150, Utilities.GetCommonQualityMeleeWeapons()[0]);
            /*
            Console.WriteLine($"Now you are in {Player.CurrentLocation.Name}");

            Player.MoveTo(RedCastle);
            Console.WriteLine(Player.Inventory.MaxVolume + "\n\n" + Player.Inventory.FilledVolume);

            Player.Inventory.Add(Utilities.GetCommonQualityPotions()[4]);
            Player.Inventory.Show();
            */
            //Window.CityScreen(RedCastle, Player);
            Window.MarketScreen(LittleVilla, Player);
        }
    }
}
