using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    abstract class Item
    {
        public string Name;
        public bool isWeapon;
        public int Price;
        public int Size;

        public abstract void Show();
    }

    class Weapon : Item
    {
        public int Damage;

        public Weapon(string name, int damage, int size, int price)
        {
            Name = name;
            Price = price;
            Size = size;
            Damage = damage;
            isWeapon = true;
        }

        public override void Show()
        {
            Console.WriteLine($"\nname = {Name}\nprice  = {Price}\n" +
                $"size = {Size}\ndamage = {Damage}\nis weapon = {isWeapon}");
        }
    }

    class Potion : Item
    {
        public int HealingPower;

        public Potion(string name, int healingPower, int size, int price)
        {
            Name = name;
            Price = price;
            Size = size;
            HealingPower = healingPower;
            isWeapon = false;
        }
        public override void Show()
        {
            Console.WriteLine($"\nname = {Name}\nprice  = {Price}\n" +
                $"size = {Size}\nhealing power = {HealingPower}\nis weapon = {isWeapon}");
        }
    }

}
