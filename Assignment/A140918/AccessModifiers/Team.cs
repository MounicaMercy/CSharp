using System;
using System.Collections.Generic;
using System.Text;

namespace A140918
{
    public class Team
    {
        internal Player[] Player = new Player[CricketSettings.PlayerSize];
        internal string Name { set; get; }
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
