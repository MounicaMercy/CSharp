using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08092018.Sports
{
    class TeamScore
    {
        public PlayerScore[] PlayerScore = new PlayerScore[CricketSettings.PlayerSize];
        public bool Iswinner = false;
        public int TotalTeamScore = 0;
        public void SetTeamScoreDetails(Team T)
        {
            Console.WriteLine("\nEnter Scores of Team ");
            for (int PsCount = 0; PsCount < CricketSettings.PlayerSize; PsCount++)
            {
                PlayerScore[PsCount] = new PlayerScore();
                PlayerScore[PsCount].Playerobj = T.Player[PsCount];
                Console.WriteLine("Enter Player Score:");
                PlayerScore[PsCount].Score = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter No of Balls:");
                PlayerScore[PsCount].Balls = int.Parse((Console.ReadLine()));
                TotalTeamScore += PlayerScore[PsCount].Score;
            }
            Console.WriteLine("The total score of the team is {0}", TotalTeamScore);
        }
    }
}
