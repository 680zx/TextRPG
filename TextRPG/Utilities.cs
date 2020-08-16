using DeflectTheBall;
using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    static class Utilities
    {

        public static Weapon[] CommonQualityMeleeWeapons = new Weapon[]
        {
            new Weapon("Wooden Mace", 10, 12, 5),
            new Weapon("Saber", 12, 6, 35),
            new Weapon("Bronze Sword", 10, 8, 25),
            new Weapon("Steel Sword", 15, 8, 35),
            new Weapon("Iron Mace", 25, 14, 40),
        };

        public static Weapon[] PerfectQualityMeleeWeapons = new Weapon[]
        {
            new Weapon("Two-handed Steel Sword", 45, 20, 120),
            new Weapon("Sharp Saber", 40, 6, 150),
            new Weapon("Wojak's Axe", 45, 12, 140),
            new Weapon("Light Spear", 55, 25, 100),
            new Weapon("Heavy Spear", 85, 35, 250)
        };

        public static Weapon[] CommonQualityRangeWeapons = new Weapon[]
        {
            new Weapon("Hunter Bow", 25, 15, 50),
            new Weapon("Three Multi Strike Bow ", 35, 17, 75),
            new Weapon("Crossbow", 20, 12, 35),
            new Weapon("Hand Cannon", 75, 25, 150),
            new Weapon("Pirate Pistol", 45, 4, 250)
        };

        public static Potion[] CommonQualityPotions = new Potion[]
        {
            new Potion("Tiny Potion", 10, 2, 5),
            new Potion("Potion", 20, 3, 10),
            new Potion("Large Potion", 30, 5, 25),
            new Potion("Fresh Bread", 5, 2, 3),
            new Potion("Healing Milk", 40, 10, 20)
        };

        public static Potion[] PerfectQualityPotions = new Potion[]
        {
             new Potion("Large Potion", 30, 5, 25),
             new Potion("Perfect Potion", 40, 5, 30),
             new Potion("Blessed Potion", 50, 5, 35),
             new Potion("Holy Potion", 60, 5, 40),
             new Potion("God's Potion", 75, 5, 45)
        };

        public static Trader[] VillageTraders = new Trader[]
        {
            new Trader("Potions and Herbs", 150, CommonQualityPotions),
            new Trader("Old Good Sword", 100, CommonQualityMeleeWeapons)
        };

        public static Trader[] CityTraders = new Trader[]
        {
            new Trader("Swords and Axes", 200, CommonQualityMeleeWeapons),
            new Trader("Bows 'n arrows", 220, CommonQualityRangeWeapons),
            new Trader("Grandma's tinctures", 100, PerfectQualityPotions),
            new Trader("Alchemist Lami", 100, CommonQualityPotions)
        };

        public static Monster GetMonster(Player player)
        {
            Monster[] monsters = new Monster[]
            {
                new Monster("Orc", 1, "Common", 80, CommonQualityMeleeWeapons[0]),
                new Monster("Elf", 2, "Common", 70, CommonQualityMeleeWeapons[1]),
                new Monster("Bandit", 3, "Common",  100, CommonQualityMeleeWeapons[3]),
                new Monster("Orc - Dux ", 4, "Rare", 170, CommonQualityMeleeWeapons[4]),
                new Monster("Elf Archer", 5, "Rare", 80, CommonQualityRangeWeapons[1]),
                new Monster("Bandit Leader", 6, "Rare", 250, CommonQualityMeleeWeapons[3]),
                new Monster("Pirate", 7, "Legendary", 120, CommonQualityRangeWeapons[4]),
                new Monster("Bounty Hunter", 8, "Legendary", 180, CommonQualityRangeWeapons[2]),
                new Monster("Knight", 9, "Legendary", 300, PerfectQualityMeleeWeapons[3])
            };

            foreach (Monster monster in monsters)
                if (monster.Level == player.Level)
                    return monster;

            return null;
        }    
    }
}
