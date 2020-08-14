using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    class Inventory
    {
        public int MaxVolume;
        public int FilledVolume;

        private List<Item> Items = new List<Item>();

        public void Show() 
        {
            Console.WriteLine("Items:");
            foreach (Item item in Items)
            {
                item.Show();
            }
        }

        public void Add(params Item[] items) 
        {
            foreach (Item item in items)
            {
                if (FilledVolume + item.Size <= MaxVolume)
                {
                    Items.Add(item);
                    FilledVolume += item.Size;
                    Console.WriteLine(item.Name + " is added to inventory.");
                }
                else
                {
                    Console.WriteLine($"\n{item.Name} is too large({item.Size}) to add to inventory({FilledVolume}/{MaxVolume})!");
                    break;
                }
                    
            }  
        }
        
        public void Remove(params Item[] items) 
        {
            foreach (Item item in items)
            {
                if (Items.Contains(item))
                {
                    FilledVolume -= item.Size;
                    Items.Remove(item);
                    Console.WriteLine(item.Name + " is removed from inventory.");
                }
                else
                {
                    Console.WriteLine("\nThis item is not in inventory!");
                    break;
                }
                    
            }  
        }

    }
}
