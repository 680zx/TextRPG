using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{

    abstract class Entity
    {
        public string Name;
        public string Race;
        public string Weapon;
        public int CurrentHealth;
        public int MaxHealth;
        public int HitPower;

        public void Hit(Entity entity)
        {
            Console.WriteLine(Name + " hit " + entity.Name + " and did " + HitPower + " damage");
            entity.CurrentHealth -= HitPower;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Characteristics of " + Name + " race " + Race +
                                ":\n\thealth: " +  CurrentHealth + "/" + MaxHealth +   "\n\thit power: " + HitPower);
        }
    }

    class Player : Entity
    {
        private Scene CurrentPosition;

        private Inventory PlayerInventory = new Inventory();
        private Squad PlayerSquad = new Squad();
        private string[] AvailableActions = new string[] {"Ударить", "Вылечиться",
            "Сменить оружие", "Просмотреть инвентарь", "Добавить в инвентарь" };
        
        public Player()
        {
            Name = SetName();
            Race = ChooseRace();
            Weapon = "";
            MaxHealth = CurrentHealth = 100;
            HitPower = 15;
        }
        /*
        public Hero(string name, string race, string weapon, int health, int hitpower)
            :base (name, race, weapon, health, hitpower)
        {

        }
        */
        /*
        public void CreateHero()
        {
            Name = AskName();
            Race = AskRace();
            Weapon = "";
            Health = 100;
            HitPower = 15;
            
        }
        */
       
        public int GetNextAction()
        {
            DisplayStats();
            Console.WriteLine("\nYour actions?");

            int i = 0;

            foreach (string action in AvailableActions)
            {
                Console.WriteLine($"\t{++i}) {action}");
            }

            int PlayerChoice = int.Parse(Console.ReadLine());
            Console.WriteLine(PlayerChoice);

            return PlayerChoice;
        }

        public void MoveTo(Scene scene)
        {
            CurrentPosition = scene;
            Console.WriteLine("You are now at " + CurrentPosition.Name);
        }

        public void RestoreHealth() 
        {
            CurrentHealth = MaxHealth;
            Console.WriteLine(Name + " restored health");
        }

        public void ChangeWeapon() 
        {
            Console.WriteLine("Changed weapon on");
        }

        public void ShowInventory()
        {
            //Console.WriteLine("Вызвать Инвентарь");
            PlayerInventory.ShowItems();
        }

        public void AddToInventory(string item)
        {
            PlayerInventory.AddItem(item);
        }

        public void BuyItem()
        {
            Console.WriteLine("Купить вещь");
        }

        public void SellItem()
        {
            Console.WriteLine("Продать вещь");
        }

        private string SetName()
        {
            Console.Write("Enter name: ");
            return Console.ReadLine();
        }

        private string ChooseRace()
        {
            Console.Write("Choose race: ");
            return Console.ReadLine();
        }

    }
    class Monster : Entity
    {
        public string GangName { get; set; }
        
        public Monster(string name, string race, int health, int hitpower)
            //: base(name, race, health, hitpower)
        {
            Name = name;
            Race = race;
            MaxHealth = CurrentHealth = health;
            HitPower = hitpower;
        }
        
        public void RunAway()
        {
            Console.WriteLine("Монстр убегает");
        }
    }
}
