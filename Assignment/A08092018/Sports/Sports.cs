using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08092018.Sports
{
    class Sports
    {
        static void Main(string[] args)
        {
            Team Team1 = new Team();
            Team1.SetDetails();
            Team Team2 = new Team();
            Team2.SetDetails();

            Match MatchOne = new Match();
            MatchOne.TeamScore1.SetTeamScoreDetails(Team1);
            MatchOne.TeamScore2.SetTeamScoreDetails(Team2);

            MatchOne.SetResult(Team1, Team2);
            MatchOne.DisplayHighestScorer();
            MatchOne.DisplayManOfTheMatch();
            Console.Read();
        }
    }
}
