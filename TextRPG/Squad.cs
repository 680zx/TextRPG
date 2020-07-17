using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    class Squad
    {
        public string SquadName { get; set; }
        private List<string> Members;
        public void ShowMembers()
        {
            Console.WriteLine("Члены отряда:");
            foreach (string member in Members)
            {
                Console.WriteLine(member);
            }
        }
    }
}
