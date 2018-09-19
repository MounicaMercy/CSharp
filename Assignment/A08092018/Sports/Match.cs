using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08092018.Sports
{
    class Match
    {
        public TeamScore TeamScore1 = new TeamScore();
        public TeamScore TeamScore2 = new TeamScore();
        public void SetResult(Team Team1, Team Team2)
        {
            if (TeamScore1.TotalTeamScore > TeamScore2.TotalTeamScore)
            {
                Console.WriteLine("\nTeam {0} is the Winning Team", Team1.Name);
                Console.Write("Winning Team Total Score is:{0}", TeamScore1.TotalTeamScore);
                TeamScore1.Iswinner = true;
            }
            else
            {
                Console.WriteLine("\nTeam {0} is the Winning Team", Team2.Name);
                Console.Write("Winning Team Total Score is:{0}", TeamScore2.TotalTeamScore);
                TeamScore2.Iswinner = true;
            }
        }
        public void DisplayManOfTheMatch()
        {

            if (TeamScore1.Iswinner == true)
            {
                //Pick up the man of the match 
                TeamScore1.PlayerScore[0].Playerobj.HighestScore = TeamScore1.PlayerScore[0].Score;
                for (int Count = 1; Count < CricketSettings.PlayerSize; Count++)
                {

                    if (TeamScore1.PlayerScore[0].Playerobj.HighestScore < TeamScore1.PlayerScore[Count].Score)
                    {
                        TeamScore1.PlayerScore[0].Playerobj.HighestScore = TeamScore1.PlayerScore[Count].Score;

                        TeamScore1.PlayerScore[0].Playerobj.Name = TeamScore1.PlayerScore[Count].Playerobj.Name;

                    }


                }
                Console.WriteLine("Man of the Match is:{0}", TeamScore1.PlayerScore[0].Playerobj.Name);

            }

            if (TeamScore2.Iswinner == true)
            {
                //Pick up the man of the match 
                TeamScore2.PlayerScore[0].Playerobj.HighestScore = TeamScore2.PlayerScore[0].Score;
                for (int Count = 1; Count < CricketSettings.PlayerSize; Count++)
                {
                    if (TeamScore2.PlayerScore[0].Playerobj.HighestScore < TeamScore2.PlayerScore[Count].Score)
                    {
                        TeamScore2.PlayerScore[0].Playerobj.HighestScore = TeamScore2.PlayerScore[Count].Score;
                        TeamScore2.PlayerScore[0].Playerobj.Name = TeamScore2.PlayerScore[Count].Playerobj.Name;
                    }
                }
                Console.WriteLine("Man of the Match is:{0}", TeamScore2.PlayerScore[0].Playerobj.Name);


            }
        }
        public void DisplayHighestScorer()

        {

            TeamScore1.PlayerScore[0].Playerobj.HighestScore = TeamScore1.PlayerScore[0].Score;
            for (int Count = 1; Count < CricketSettings.PlayerSize; Count++)
            {
                if (TeamScore1.PlayerScore[0].Playerobj.HighestScore < TeamScore1.PlayerScore[Count].Score)
                {
                    TeamScore1.PlayerScore[0].Playerobj.HighestScore = TeamScore1.PlayerScore[Count].Score;
                    TeamScore1.PlayerScore[0].Playerobj.Name = TeamScore1.PlayerScore[Count].Playerobj.Name;
                }
            }
            Console.WriteLine("\nHighest Score of Team 1:{0}\nName of the Highest Scorer {1}", TeamScore1.PlayerScore[0].Playerobj.HighestScore, TeamScore1.PlayerScore[0].Playerobj.Name);

            TeamScore2.PlayerScore[0].Playerobj.HighestScore = TeamScore2.PlayerScore[0].Score;
            for (int Count = 1; Count < CricketSettings.PlayerSize; Count++)
            {
                if (TeamScore2.PlayerScore[0].Playerobj.HighestScore < TeamScore2.PlayerScore[Count].Score)
                {
                    TeamScore2.PlayerScore[0].Playerobj.HighestScore = TeamScore2.PlayerScore[Count].Score;
                    TeamScore2.PlayerScore[0].Playerobj.Name = TeamScore2.PlayerScore[Count].Playerobj.Name;
                }
            }
            Console.WriteLine("Highest Score of Team 2:{0}\nName of the Highest Scorer {1}", TeamScore2.PlayerScore[0].Playerobj.HighestScore, TeamScore2.PlayerScore[0].Playerobj.Name);


        }
    }
}
