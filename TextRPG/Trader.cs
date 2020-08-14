using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    class Trader
    {
        public string StoreName;
        public int Gold;

        public Item[] Items = new Item[5];

        public Trader(string storeName, int gold, params Item[] items)
        {
            StoreName = storeName;
            Gold = gold;
            Items = items;
        }
    }
}
