using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    abstract class Scene
    {
        public string Name;
        public int NumberOfTraders;
        public int Population;

        public Scene(string name, int tradersNum, int population)
        {
            Name = name;
            NumberOfTraders = tradersNum;
            Population = population;
        }
    }

    class Village:Scene
    {
        public Village(string name, int tradersNum, int population) : base(name, tradersNum, population)
        {
            Console.WriteLine(Name + " village");
        }

    }
    
    class City:Scene
    {
        public City(string name, int tradersNum, int population) : base(name, tradersNum, population)
        {
            Console.WriteLine("Город" + Name);
        }

    }
}
