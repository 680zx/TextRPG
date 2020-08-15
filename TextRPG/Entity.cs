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
        public int Level;
        public int Gold;
        public bool isDead;

        public void Hit(Entity entity)
        {
            Console.WriteLine(Name + " hit " + entity.Name + " and did " + Weapon.Power + " damage");
            entity.CurrentHealth -= Weapon.Power;
        }

        public void ShowStats()
        {
            Console.WriteLine("\n\n\tCharacteristics of " + Name + " race " + Race +
                                "health: " +  CurrentHealth + "/" + MaxHealth +   "\n\thit power: " + Weapon.Power);
        }
    }

    class Player : Entity
    {
        public Scene CurrentLocation;
        public Potion Potion;

        public Inventory Inventory = new Inventory();
        private Squad PlayerSquad = new Squad();
        public string[] BattleActions = new string[] {"Hit monster", "Heal myself", "Change weapon"};
        
        public Player(Scene InitilalLocation)
        {
            //Weapon = weapon;
            //Potion = potion;
            MaxHealth = CurrentHealth = 100;
            HitPower = 15;
            Inventory.MaxVolume = 20;
            Gold = 50;
            Level = 1;
            isDead = false;
            CurrentLocation = InitilalLocation;
            //Inventory.Add(Weapon, Potion);
        }
       
        public int GetBattleAction()
        {
            //ShowStats();
            //Console.WriteLine("\nYour actions?");
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
            if (CurrentHealth + Potion.Power >= MaxHealth)
                CurrentHealth = MaxHealth;
            else
                CurrentHealth += Potion.Power;
            Console.WriteLine(Name + " restored health");
        }

        public void ChangeWeapon() 
        {
            Console.WriteLine("Changed weapon on");
        }

        public void BuyItem()
        {
            Console.WriteLine("Купить вещь");
        }

        public void SellItem()
        {
            Console.WriteLine("Продать вещь");
        }

        public string SetName()
        {
            Console.Write("Enter name: ");
            return Console.ReadLine();
        }

        public string ChooseRace()
        {
            Console.Write("\n\tEnter race: ");
            return Console.ReadLine();
        }

    }
    class Monster : Entity
    {
        public string GangName { get; set; }
        public string Rank;
        
        public Monster(string race, int level, string rank, int health,  Weapon weapon)
            //: base(name, race, health, hitpower)
        {
            Race = race;
            Level = level;
            Rank = rank;
            MaxHealth = CurrentHealth = health; 
            Weapon = weapon;
        }
        
        public void RunAway()
        {
            Console.WriteLine("Монстр убегает");
        }
    }
}
