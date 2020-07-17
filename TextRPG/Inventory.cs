using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    class Inventory
    {
        private List<string> Items = new List<string>();

        public void ShowItems() 
        {
            Console.WriteLine("Ваш инвентарь:");
            foreach (string item in Items)
            {
                Console.WriteLine("\t" + item);
            }
        }
        public void AddItem(string item) 
        {
            Items.Add(item);
            Console.WriteLine("Добавлен предмет: " + item);
        }
    }
}
