using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaguePredictor
{
    class Fixtures : IComparable
    {
        //field variable
        private Teams homeTeam;
        private Teams awayTeam;
        private int homeTeamScore;
        private int awayTeamScore;

        //constructor call to create object team
        public Fixtures(Teams homeTeam, Teams awayTeam)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
        }

        public Teams GetHomeTeam()
        {
            return this.homeTeam;
        }

        public Teams GetAwayTeam()
        {
            return this.awayTeam;
        }

        public void SetHomeTeam(Teams homeTeam)
        {
            this.homeTeam = homeTeam;
        }

        public void SetAwayTeam(Teams awayTeam)
        {
            this.homeTeam = awayTeam;
        }

        public int GetHomeScore()
        {
            return this.homeTeamScore;
        }

        public void SetHomeScore(int score)
        {
            this.homeTeamScore = score;
        }

        public int GetAwayScore()
        {
            return this.awayTeamScore;
        }

        public void SetAwayScore(int score)
        {
            this.awayTeamScore = score;
        }

        public int CompareTo(object obj)
        {

            return (homeTeam.totalPoints - awayTeam.GetPoints);

        }
    }  
}
