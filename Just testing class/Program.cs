using System;
using System.Collections.Generic;

namespace Just_testing_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SurveyedCitizen> SurveyData = new List<SurveyedCitizen>();

            string[] TownID = new string[]
            {
                "DUNE","AUCK","WELT",
                "CHSC","HAMT","INVC",
            };
            string[] TownName = new string[]
            {
                "Dunedin","Auckland","Wellinton",
                "Christchurch","Hamilton","Invercargill",
            };

            SurveyData.Add(new SurveyedCitizen("hawkins", "kapo", TownID[1], 2004));
            int a = 0;
            Console.WriteLine($" [{SurveyData[a].TownID} {SurveyData[a].SurveyID}] {SurveyData[a].FirstName} {SurveyData[a].Surname} {SurveyData[a].BirthYear} ");
        }
    }
}