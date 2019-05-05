using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaguePredictor
{
    class Program
    {
        static void Main(string[] args)
        {

            Teams[] teams = new Teams[2];

            teams[0] = new Teams("Arsenal",0);
            teams[1] = new Teams("Bournemouth",0);
            //teams[2] = new Teams("Brighton",0);
            //teams[3] = new Teams("Burnley",0);
            //teams[4] = new Teams("Cardiff City",0);
            //teams[5] = new Teams("Chelsea",0);
            //teams[6] = new Teams("Crystal Palace",0);
            //teams[7] = new Teams("Everton",0);
            //teams[8] = new Teams("Fulham",0);
            //teams[9] = new Teams("Huddersfield",0);
            //teams[10] = new Teams("Liecester City",0);
            //teams[11] = new Teams("Liverpool",0);
            //teams[12] = new Teams("Manachester City",0);
            //teams[13] = new Teams("Manachester United",0);
            //teams[14] = new Teams("Newcastle",0);
            //teams[15] = new Teams("Southampton",0);
            //teams[16] = new Teams("Tottenham",0);
            //teams[17] = new Teams("Watford",0);
            //teams[18] = new Teams("West Ham",0);
            //teams[19] = new Teams("Wolverhampton Wanderers",0);

            //Create fixtures
            List<Fixtures> fixtureList = new List<Fixtures>();

           //Console.WriteLine("team length " + teams.Length);
            for (int homeTeam = 0; homeTeam < teams.Length; homeTeam++)
            {
                for (int awayTeam = 0; awayTeam < teams.Length; awayTeam++)
                { 
                    //Console.WriteLine(homeTeam + " " + awayTeam);
                    if (awayTeam != homeTeam)
                    {
                        Teams tempHomeTeam = teams[homeTeam];
                        Teams tempAwayTeam = teams[awayTeam];

                        Fixtures tempFixtures = new Fixtures(teams[homeTeam], teams[awayTeam]);
                        fixtureList.Add(tempFixtures);
                    }
                }
            }
            //PrintList(fixtureList);
            fixtureList = Shuffle(fixtureList);
            fixtureList = InputScore(fixtureList);

            Console.ReadLine();
            PrintList(fixtureList);
            Console.ReadLine();
         }

        private static List<Fixtures> Shuffle<Fixtures>(List<Fixtures> unshuffledList)
        {
            List<Fixtures> shuffledList = new List<Fixtures>();

            Random rand = new Random();
            int randomIndex = 0;
            while (unshuffledList.Count > 0)
            {
                randomIndex = rand.Next(0, unshuffledList.Count);
                shuffledList.Add(unshuffledList[randomIndex]);
                unshuffledList.RemoveAt(randomIndex);
            }

            return shuffledList;

        }

        private static void PrintList(List<Fixtures> PrintedList)
        {
            for (int lines = 0; lines < PrintedList.Count; lines++)
            {
                Console.WriteLine(PrintedList[lines].GetHomeTeam().GetTeamName() + " " + PrintedList[lines].GetHomeScore() + " vs " + PrintedList[lines].GetAwayTeam().GetTeamName() + " " + PrintedList[lines].GetAwayScore());
            }
        }

        //Add the score to the teams in the fixture list
        private static List<Fixtures> InputScore(List<Fixtures> shuffledList)
        {
            for (int lines = 0; lines < shuffledList.Count; lines++)
            {
                int homeTeamScore = 0;
                int awayTeamScore = 0;

                Console.WriteLine(shuffledList[lines].GetHomeTeam().GetTeamName() + " " +  " vs " + shuffledList[lines].GetAwayTeam().GetTeamName() + ".");
                if (homeTeamScore == 0)
                {

                    Console.WriteLine("Please input predicted score of " + shuffledList[lines].GetHomeTeam().GetTeamName() + ".");
                    string homeScore = Console.ReadLine();
                    int homeScoreConverted = Int32.Parse(homeScore);
                    shuffledList[lines].SetHomeScore(homeScoreConverted);
                }

                if (awayTeamScore == 0)
                {

                    Console.WriteLine("Please input predicted score of " + shuffledList[lines].GetAwayTeam().GetTeamName() + ".");
                    string awayScore = Console.ReadLine();
                    int awayScoreConverted = Int32.Parse(awayScore);
                    shuffledList[lines].SetAwayScore(awayScoreConverted);
                }
            }
            return shuffledList;
        }

       //assign the points to the teams depending on 3 points for a win, 1 point for a draw and 0 points for a lose
        private static void TeamsTotalPoints(List<Fixtures> shuffledList)
        {
            for (int lines = 0; lines < shuffledList.Count; lines++)
            {
                int homeScore = shuffledList[lines].GetHomeScore();
                int awayScore = shuffledList[lines].GetAwayScore();
                int homePoints = shuffledList[lines].GetHomeTeam().GetPoints();
                int awayPoints = shuffledList[lines].GetAwayTeam().GetPoints();

                if (homeScore < awayScore)
                {
                    homePoints += 0;
                    awayPoints += 3;
                }

                else if (homeScore > awayScore)
                {
                    homePoints += 3;
                    awayPoints += 0;
                }

                else
                {
                    homePoints += 1;
                    awayPoints += 1;
                }
            }
        }

        //Sort Teams int a list with the highest points first
        private static void SortList(List<Teams[]> sortedList)
        {
            Array.Sort(Teams);

            for (int lines = 0; lines < sortedList.Count; lines++)
            {
                Console.WriteLine(sortedList[lines].GetHomeTeam().GetTeamName() + " " + sortedList[lines].GetPoints() + " vs " + sortedList[lines].GetAwayTeam().GetTeamName() + " " + sortedList[lines].GetPoints());
            }
        }
    }
}
