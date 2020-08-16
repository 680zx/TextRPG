using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    abstract class Scene
    {
        public string Name;
        public Trader[] Traders;
        public int Population;


        public Scene(string name, int population, Trader[] traders)
        {
            Name = name;
            Traders = traders;
            Population = population;
        }
    }

    class Village:Scene
    {
        public Village(string name, int population, Trader[] traders) : base(name, population, traders)
        {
            //Console.WriteLine(Name + " village");
        }

    }
    
    class City:Scene
    {
        public City(string name, int population, Trader[] traders) : base(name, population, traders)
        {
            //Console.WriteLine(Name + " city");
        }
    }

    class Market : Scene
    {
        public Market(string name, int population, Trader[] traders) : base(name, population, traders)
        {
            //Console.WriteLine(Name + " village");
        }
    }
}
