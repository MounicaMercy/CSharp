using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08092018.Sports
{
    class Team
    {
        public Player[] Player = new Player[CricketSettings.PlayerSize];
        public string Name { set; get; }
        public void SetDetails()
        {
            Console.WriteLine("Enter Team Name");
            Name = Console.ReadLine();
            for (int PlayerCount = 0; PlayerCount < CricketSettings.PlayerSize; PlayerCount++)
            {
                Player[PlayerCount] = new Player();
                Console.WriteLine("Enter Players Name");
                Player[PlayerCount].Name = Console.ReadLine();
            }
        }
    }
}
