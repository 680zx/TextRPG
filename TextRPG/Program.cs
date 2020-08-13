using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Player = new Player();
            Monster Creepy = new Monster("Uruglah", "Orc", 150, 10);
            Village LittleVilla = new Village("Little Villa", 2, 200);

            Player.DisplayStats();
            Creepy.DisplayStats();

            Player.MoveTo(LittleVilla);

            Player.Hit(Player);
            Creepy.DisplayStats();

            Creepy.Hit(Creepy);
            Player.DisplayStats();

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
