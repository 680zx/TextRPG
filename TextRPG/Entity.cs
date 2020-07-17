using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    abstract class Entity
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Weapon { get; set; }
        public int Health { get; set; }
        public int HitPower { get; set; }
        public Entity() { }
        public Entity(string name, string race, int health, int hitpower)
        {
            Name = name;
            Race = race;
            Health = health;
            HitPower = hitpower;
            Weapon = "Дубина";
        }
        public Entity(string name, string race, string weapon, int health, int hitpower)
        {
            Name = name;
            Race = race;
            Health = health;
            HitPower = hitpower;
            Weapon = weapon;
        }
        public void Hit(Entity entity)
        {
            Console.WriteLine(Name + " ударил " + entity.Name + " и нанес урон " + HitPower);
            entity.Health -= HitPower;
        }
        public void DisplayCharacteristics()
        {
            Console.WriteLine("Характеристики " + Name + " расы " + Race +
                                ":\n\tздоровье: " +  Health + "\n\tсила удара: " + HitPower);
        }
        
    }

    class Hero : Entity
    {
        private Inventory PlayerInventory = new Inventory();
        private Squad PlayerSquad = new Squad();
        private string[] AvailableAtions = new string[] {"Ударить", "Вылечиться",
            "Сменить оружие", "Просмотреть инвентарь", "Добавить в инвентарь" };

        public Hero() 
        {
            Name = AskName();
            Race = AskRace();
            Weapon = "";
            Health = 100;
            HitPower = 15;
        }
        public Hero(string name, string race, string weapon, int health, int hitpower)
            :base (name, race, weapon, health, hitpower)
        {

        }

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
       

        private string AskName()
        {
            Console.Write("Введите имя: ");
            return Console.ReadLine();
        }

        private string AskRace()
        {
            Console.Write("Введите расу: ");
            return Console.ReadLine();
        }

        public int GetAction()
        {
            //Вывод информации о текущем состоянии игрока, опрос о следующем действии.
            DisplayCharacteristics();
            Console.WriteLine("\nВаши действия?");

            int i = 0;
            foreach (string action in AvailableAtions)
            {
                i++;
                Console.WriteLine("\t" + i + ") " + action);
            }
            int PlayerChoice = int.Parse(Console.ReadLine());
            Console.WriteLine(PlayerChoice);

            return PlayerChoice;
        }

        public void RestoreHealth() 
        {
            Health = 100;
            Console.WriteLine(Name + " восстановил здоровье");
        }
        public void ChangeWeapon() 
        {
            Console.WriteLine("Сменил оружие");
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

    }
    class Monster : Entity
    {
        public string GangName { get; set; }
        public Monster(string name, string race, int health, int hitpower)
            : base(name, race, health, hitpower)
        {

        }

        public void RunAway()
        {
            Console.WriteLine("Монстр убегает");
        }
    }
}
