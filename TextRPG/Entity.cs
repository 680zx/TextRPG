using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextRPG
{

    abstract class Entity
    {
        public string Name;
        public string Race;
        public Weapon _weapon;
        public int CurrentHealth;
        public int MaxHealth;
        public int HitPower;
        public int Level;
        public int Gold;
        public bool isDead;

        public abstract void Hit(Entity entity);

        public void ShowStats()
        {
            Console.WriteLine("\n\n\tCharacteristics of " + Name + " race " + Race +
                                "health: " +  CurrentHealth + "/" + MaxHealth +   "\n\thit power: " + _weapon.Power);
        }
    }

    class Player : Entity
    {
        public Scene CurrentLocation;
        public Potion _potion;

        public Inventory Inventory = new Inventory();
        private Squad PlayerSquad = new Squad();
        public string[] BattleActions = new string[] {"Hit monster", "Heal myself", "Change weapon"};
        
        public Player(Scene InitilalLocation, Weapon weapon)
        {
            _weapon = weapon;
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

        public override void Hit(Entity monster)
        {
            monster.CurrentHealth -= _weapon.Power;
            if (monster.CurrentHealth <= 0)
                monster.isDead = true;
        }

        public void MoveTo(Scene scene)
        {
            CurrentLocation = scene;
            Console.WriteLine("You are now in " + CurrentLocation.Name);
        }

        public void RestoreHealth() 
        {
            var index = Inventory.Items.FindIndex(x => x.isWeapon == false);
            if (index != -1)
            {
                _potion = (Potion)Inventory.Items[index];
                Inventory.Items.RemoveAt(index);

                if (CurrentHealth + _potion.Power >= MaxHealth)
                    CurrentHealth = MaxHealth;
                else
                    CurrentHealth += _potion.Power;
                Console.WriteLine("\n\t" + Name + " restored health.");
            }
            else
                Console.WriteLine("\n\tHealing potions is out.");
            
        }

        public void ChangeWeapon() 
        {
            Console.WriteLine("Changed weapon on ");
        }

        public void BuyItem()
        {
            Console.WriteLine("Купить вещь");
        }

        public void SellItem()
        {
            Console.WriteLine("Продать вещь");
        }

        public void SetName()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            //return Console.ReadLine();
        }

        public void ChooseRace()
        {
            Console.Write("\n\tEnter race: ");
            Race = Console.ReadLine();
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
            _weapon = weapon;
        }

        public override void Hit(Entity player)
        {
            player.CurrentHealth -= _weapon.Power;
            
            if (player.CurrentHealth <= 0)
                player.isDead = true;
        }

        public void RunAway()
        {
            Console.WriteLine("Монстр убегает");
        }
    }
}
