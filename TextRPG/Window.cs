using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TextRPG;

namespace DeflectTheBall
{
    static class Window
    {
        public static int Width, Height;
        private static string header;
        private static char[] line;

        public static void GameMenu()
        {
            Console.Clear();

            header = "TextRPG";
            Console.SetCursorPosition((Width - header.Length) / 2, 4);

            Console.Write(header +
                "\n\n\n\n\tMenu:" +
                "\n\t1) Play" +
                "\n\t2) Help" +
                "\n\t3) Exit\n\n");
            CreateScreen();
        }

        public static void CreationScreen()
        {
            Console.Clear();
            CreateScreen();

            header = "Creation Menu";
            Console.SetCursorPosition((Width - header.Length) / 2, 4);
            Console.Write(header);
            Console.SetCursorPosition((Width - header.Length) / 2, 5);

            line = new char[header.Length];
            Array.Fill(line, '*');
            Console.Write(line);
            Console.SetCursorPosition(8, 8);
        }

        public static void VillageScreen(Village village, Player player)
        {
            Console.Clear();

            header = "Welcome to the " + village.Name;
            Console.SetCursorPosition((Width - header.Length) / 2, 4);
            Console.Write(header);
            Console.SetCursorPosition((Width - header.Length) / 2, 5);

            line = new char[header.Length];
            Array.Fill(line, '~');
            Console.Write(line);

            Console.SetCursorPosition(8, 8);
            Console.Write($"Ohh, it's you, my dear {player.Name}. Nice to meet you again!\n" +
                $"\tWhat is your goal this time?" +
                $"\n\n\t1) Clear the Dungeon" +
                $"\n\t2) Buy equipment" +
                $"\n\t3) Move to the Red Castle" +
                $"\n\t4) Exit");

            CreateScreen();
        }
        
        public static void CityScreen(City city, Player player)
        {
            Console.Clear();

            header = "Welcome to the " + city.Name;
            Console.SetCursorPosition((Width - header.Length) / 2, 4);
            Console.Write(header);
            Console.SetCursorPosition((Width - header.Length) / 2, 5);

            line = new char[header.Length];
            Array.Fill(line, '=');
            Console.Write(line);

            Console.SetCursorPosition(8, 8);
            Console.Write($"The glorious city {city.Name} greets you. The latest news " +
                $"\n\tabout your exploits is incredible. What do you intend to " +
                $"\n\tdo this time?" +
                $"\n\n\t1) Clear the Dungeon" +
                $"\n\t2) Buy equipment" +
                $"\n\t3) Move to the Little Villa" +
                $"\n\t4) Exit");

            CreateScreen();
        }

        public static void MarketScreen(Scene scene, Player player)
        {
            Console.Clear();

            header = "Market of the " + scene.Name;
            Console.SetCursorPosition((Width - header.Length) / 2, 4);
            Console.Write(header);
            Console.SetCursorPosition((Width - header.Length) / 2, 5);

            line = new char[header.Length];
            Array.Fill(line, '-');
            Console.Write(line);

            Console.SetCursorPosition(8, 8);
            Console.Write($"Sell, sell... Can you hear this crazy traders? They just " +
                $"\n\twant one thing - to sell you their stuff. Umm, maybe it's" +
                $"\n\tonly thanks to you that they can sell something?\n");

            int j = 1;
            for (int i = 0; i < scene.Traders.Length; i++, j++)
            {
                Console.Write($"\n\t{j}) Move to the {scene.Traders[i].StoreName}");
            }

            Console.Write($"\n\t{j}) Return to the {scene.Name}");

            CreateScreen();
        }

        public static void TradeScreen(Trader trader, Player player)
        {
            Console.Clear();

            header = trader.StoreName;
            Console.SetCursorPosition((Width - header.Length) / 2, 4);
            Console.Write(header);
            Console.SetCursorPosition((Width - header.Length) / 2, 5);

            line = new char[header.Length];
            Array.Fill(line, '.');
            Console.Write(line);

            Console.SetCursorPosition(8, 8);
            Console.Write($"Ho-ho-ho, welcome back, {player.Name}. I brought a lot" +
                $"\n\tof new goods:\n");
            Console.Write("\n\t\tName\t\tPower\tSize\tPrice\n");

            int j = 1;
            for (int i = 0; i < trader.Items.Length; i++, j++)
            {
                Console.Write($"\n\t{j}) {trader.Items[i].Name}\t\t" +
                    $"{trader.Items[i].Power}\t{trader.Items[i].Size}\t{trader.Items[i].Price}");
            }

            Console.Write($"\n\t{j}) Return to the market");

            Console.SetCursorPosition(8, Height - 4);
            Console.Write($"My Gold: {player.Gold}\tBag volume: " +
                $"{player.Inventory.FilledVolume}/{player.Inventory.MaxVolume}");

            CreateScreen();
        }

        public static void BattleScreen(Player player, Monster monster)
        {
            Console.Clear();
            CreateScreen();

            header = monster.Rank + " Battle";
            Console.SetCursorPosition((Width - header.Length) / 2, 4);
            Console.Write(header);
            Console.SetCursorPosition((Width - header.Length) / 2, 5);

            line = new char[header.Length];
            Array.Fill(line, 'V');
            Console.Write(line);

            Console.SetCursorPosition(8, 8);
            Console.Write($"This dirty {monster.Race} level {monster.Level} attacked me. " +
                $"What will I do?\n");
            
            int i = 0;
            foreach (string action in player.BattleActions)
            {
                Console.Write($"\n\t{++i}) {action}");
            }

        }

        public static void BattleActionScreen(Player player, Monster monster)
        {
            Console.SetCursorPosition(8, 10);
            Console.Write($"{player.Name} health: {player.CurrentHealth}" +
                            $"\t{monster.Name} health:\t{monster.CurrentHealth}");
        }

        public static void GamePlayScreen()
        {
            CreateFrame();

        }        

        public static void HelpScreen()
        {
            Console.Clear();

            header = "HELP";
            Console.SetCursorPosition((Width - header.Length) / 2, 4);

            do
            {
                Console.Write(header +
                "\n\n\tUse Left Arrow and Right Arrow" +
                "\n\tbuttons to control the position" +
                "\n\tof the platform" +
                "\n\n\tPress Escape button to return" +
                "\n\tto the main menu");
                CreateScreen();
            }
            while (Console.ReadKey().Key.ToString() != "Escape");
        }

        public static void GameOverScreen()
        {
            string msg = "You Died";
            Console.Clear();
            Console.SetCursorPosition((Width - msg.Length) / 2, Height / 2);
            Console.WriteLine(msg);  
        }

        public static void WinnerScreen()
        {
            string msg = "You Win!";
            Console.Clear();
            Console.SetCursorPosition((Width - msg.Length) / 2, Height / 2);
            Console.WriteLine(msg);
        }

        private static void CreateScreen()
        {
            Console.WindowHeight = Height;
            Console.WindowWidth = Width;
            CreateFrame();
        }

        private static void CreateFrame()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (i == 0 || j == 0 || i == Width - 1 || j == Height - 1)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("=");
                    }
                }
            }
        }

        
    }
}