using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{

    abstract class Entity
    {
        public string Name;
        public string Race;
        public Weapon Weapon;
        public int CurrentHealth;
        public int MaxHealth;
        public int HitPower;

        public void Hit(Entity entity)
        {
            Console.WriteLine(Name + " hit " + entity.Name + " and did " + Weapon.Damage + " damage");
            entity.CurrentHealth -= Weapon.Damage;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Characteristics of " + Name + " race " + Race +
                                ":\n\thealth: " +  CurrentHealth + "/" + MaxHealth +   "\n\thit power: " + Weapon.Damage);
        }
    }

    class Player : Entity
    {
        public Scene CurrentLocation;
        public Potion Potion;

        public Inventory Inventory = new Inventory();
        private Squad PlayerSquad = new Squad();
        private string[] AvailableActions = new string[] {"Ударить", "Вылечиться",
            "Сменить оружие", "Просмотреть инвентарь", "Добавить в инвентарь" };
        
        public Player(Scene InitilalLocation, Weapon weapon, Potion potion)
        {
            Name = "TestName";//SetName();
            Race = "TestRace";//ChooseRace();
            Weapon = weapon;
            Potion = potion;
            MaxHealth = CurrentHealth = 100;
            HitPower = 15;
            Inventory.MaxVolume = 20;
            CurrentLocation = InitilalLocation;
            Inventory.Add(Weapon, Potion);
        }
       
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
            CurrentLocation = scene;
            Console.WriteLine("You are now in " + CurrentLocation.Name);
        }

        public void RestoreHealth() 
        {
            if (CurrentHealth + Potion.HealingPower >= MaxHealth)
                CurrentHealth = MaxHealth;
            else
                CurrentHealth += Potion.HealingPower;
            Console.WriteLine(Name + " restored health");
        }

        public void ChangeWeapon() 
        {
            Console.WriteLine("Changed weapon on");
        }

        public void ShowInventory()
        {
            //Console.WriteLine("Вызвать Инвентарь");
            Inventory.Show();
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
        
        public Monster(string name, string race, int health, Weapon weapon)
            //: base(name, race, health, hitpower)
        {
            Name = name;
            Race = race;
            MaxHealth = CurrentHealth = health;
            Weapon = weapon;
        }
        
        public void RunAway()
        {
            Console.WriteLine("Монстр убегает");
        }
    }
}
