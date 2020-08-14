using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    static class Utilities
    {
        public static Weapon[] GetCommonQualityMeleeWeapons()
        {
            Weapon[] weapons = new Weapon[]
            {
                new Weapon("Wooden Mace", 10, 12, 5),
                new Weapon("Saber", 12, 6, 35),
                new Weapon("Iron Sword", 10, 8, 25),
                new Weapon("Steel Sword", 15, 8, 35),
                new Weapon("Iron Mace", 25, 14, 40)
            };

            return weapons;
        }

        public static Weapon[] GetCommonQualityRangeWeapons()
        {
            Weapon[] weapons = new Weapon[]
            {
                new Weapon("Hunter Bow", 25, 15, 50),
                new Weapon("Three Multi Strike Bow ", 35, 17, 75),
                new Weapon("Crossbow", 20, 12, 35),
                new Weapon("Hand Cannon", 75, 25, 150),
                new Weapon("Pirate Pistol", 40, 8, 250)
            };

            return weapons;
        }

        public static Potion[] GetCommonQualityPotions()
        {
            Potion[] potions = new Potion[]
            {
                new Potion("Tiny Potion", 10, 2, 5),
                new Potion("Potion", 20, 3, 10),
                new Potion("Large Potion", 30, 5, 25),
                new Potion("Fresh Bread", 5, 2, 3),
                new Potion("Healing <Thank you, cow> Milk", 40, 10, 20)
            };

            return potions;
        }

        public static Potion[] GetPerfectQualityPotions()
        {
            Potion[] potions = new Potion[]
            {
                 new Potion("Large Potion", 30, 5, 25),
                 new Potion("Perfect Potion", 40, 5, 30),
                 new Potion("Blessed Potion", 50, 5, 35),
                 new Potion("Holy Potion", 60, 5, 40),
                 new Potion("God's Potion", 75, 5, 45)
            };

            return potions;
        }

        public static Trader[] GetVillageTraders()
        {
            Trader[] traders = new Trader[]
            {
                new Trader("Potions and Herbs", 150, GetCommonQualityPotions()),
                new Trader("Old Good Sword", 100, GetCommonQualityMeleeWeapons())
            };

            return traders;
        }

        public static Trader[] GetCityTraders()
        {
            Trader[] traders = new Trader[]
            {
                new Trader("Swords and Axes", 200, GetCommonQualityMeleeWeapons()),
                new Trader("Bows 'n arrows", 220, GetCommonQualityRangeWeapons()),
                new Trader("Grandma's tinctures", 100, GetPerfectQualityPotions()),
                new Trader("Rokkie Lami", 100, GetCommonQualityPotions())
            };

            return traders;
        }
    }
}
