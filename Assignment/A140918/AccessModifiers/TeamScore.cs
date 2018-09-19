using System;
using System.Collections.Generic;
using System.Text;

namespace A140918
{
    public class TeamScore : Team
    {
        internal PlayerScore[] PlayerScore = new PlayerScore[CricketSettings.PlayerSize];
        internal bool Iswinner = false;
        internal int TotalTeamScore = 0;
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
