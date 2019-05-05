using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaguePredictor
{
    class Teams
    {
        //field variable
        private string teamName;
        private int totalPoints;

        //constructor call to create object Teams
        public Teams(string teamName, int points)
        {
            this.teamName = teamName;
            this.totalPoints = points;
        }

        public string GetTeamName()
        {
            return this.teamName;
        }

        public void SetTeamName(string teamName)
        {
            this.teamName = teamName;
        }

        public int GetPoints()
        {
            return this.totalPoints;
        }

        public void SetPoints(int points)
        {
            this.totalPoints = points;
        }
    }
}

