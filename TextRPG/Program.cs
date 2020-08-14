using DeflectTheBall;
using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Window.Width = 100;
            Window.Height = 40;
            //Window.GameMenu();

            
            Village LittleVilla = new Village("Little Villa", 2, 200);
            City RedCastle = new City("Red Castle", 4, 1000);

            Weapon WoodenMace = new Weapon("Wooden mace", 10, 5, 3);
            Weapon Saber = new Weapon("Saber", 20, 10, 25);
            Weapon LegendarySaber = new Weapon("Legendary Saber", 20, 17, 25);
            Potion LargePotion = new Potion("Large healing potion", 20, 5, 10);

            Player Player = new Player(LittleVilla, Saber, LargePotion);
            Monster Creepy = new Monster("Uruglah", "Orc", 150, WoodenMace);

            Console.WriteLine($"Now you are in {Player.CurrentLocation.Name}");

            Player.MoveTo(RedCastle);
            Console.WriteLine(Player.Inventory.MaxVolume + "\n\n" + Player.Inventory.FilledVolume);

            Player.Inventory.Add(LegendarySaber);
            Player.Inventory.Show();

            /*
            Player.Inventory.RemoveItem(LargePotion);
            Player.Inventory.RemoveItem(LargePotion);
            Player.Inventory.RemoveItem(Saber);
            Player.ShowInventory();
            Player.Inventory.RemoveItem(WoodenMace);
            */
            /*
            Player.DisplayStats();
            Creepy.DisplayStats();

            Player.MoveTo(LittleVilla);

            Player.Hit(Creepy);
            Creepy.DisplayStats();
            
            Creepy.Hit(Player);
            Player.DisplayStats();

            Player.RestoreHealth();
            Player.DisplayStats();
            */
            /*
            void AskAction()
            {
                //Вывод информации о текущем состоянии игрока, опрос о следующем действии.
                switch(Player.GetAction())
                {
                    case 1:
                        Player.Hit(Creepy);
                        break;
                    case 2:
                        Player.RestoreHealth();
                        break;
                    case 3:
                        Player.ChangeWeapon();
                        break;
                    case 4:
                        Player.ShowInventory();
                        break;
                    case 5:
                        Player.AddToInventory("Мечч");
                        break;
                }
            }

            Console.WriteLine("Вы идете по тропинке, вам встречается монстр " + Creepy.Name +
                ". Он вероломно нападает на вас\nи наносит урон " + Creepy.HitPower);
            Creepy.Hit(Player);
            while (true)
            {
                AskAction();
                Creepy.DisplayCharacteristics();
            }
            
            */
        }
        
        
        
    }
}
