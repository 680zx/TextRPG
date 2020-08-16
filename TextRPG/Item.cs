using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    abstract class Item
    {
        public int Power;
        public string Name;
        public bool isWeapon;
        public int Price;
        public int Size;

        public abstract void Show();
    }

    class Weapon : Item
    {
        public Weapon(string name, int damage, int size, int price)
        {
            Name = name;
            Price = price;
            Size = size;
            Power = damage;
            isWeapon = true;
        }

        public override void Show()
        {
            Console.WriteLine($"\nname = {Name}\nprice  = {Price}\n" +
                $"size = {Size}\ndamage = {Power}\nis weapon = {isWeapon}");
        }
    }

    class Potion : Item
    {

        public Potion(string name, int healingPower, int size, int price)
        {
            Name = name;
            Price = price;
            Size = size;
            Power = healingPower;
            isWeapon = false;
        }
        public override void Show()
        {
            Console.WriteLine($"\nname = {Name}\nprice  = {Price}\n" +
                $"size = {Size}\nhealing power = {Power}\nis weapon = {isWeapon}");
        }
    }

}
