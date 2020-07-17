using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Player = new Hero();
            Monster Creepy = new Monster("Uruglah", "Orc", 150, 10);
            //Player.DisplayCharacteristics();
            //Creepy.DisplayCharacteristics();
            /*
            BasicMan.Hit(Creepy);
            Creepy.DisplayCharacteristics();

            Creepy.Hit(BasicMan);
            BasicMan.DisplayCharacteristics();
            
            BasicMan.RestoreHealth();
            BasicMan.ShowInventory();
            BasicMan.SellItem();
            BasicMan.BuyItem();
            BasicMan.ChangeWeapon();

            BasicMan.PlayerInventory.AddItem("Дубина орчья");

            BasicMan.PlayerSquad.ShowMembers();
            
            BasicMan.RestoreHealth();
            BasicMan.DisplayCharacteristics();
            */

            
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
            

        }
        
        
        
    }
}
