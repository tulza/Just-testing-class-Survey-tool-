using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Just_testing_class
{
    internal class SurveyedCitizen
    {
        //Citizen Info
        //Member Variable <!>
        string firstName;
        string surname;
        string townID;
        int birthYear;
        string surveyID;

        //Database Info
        int totalSurvey = 0; // To be implemented 


        //The constructor <!>
        public SurveyedCitizen(string ArgsFirstName, string ArgsSurname, string ArgTown, int ArgsBirthYear)
        {
            firstName = ArgsFirstName;
            surname = ArgsSurname;
            townID = ArgTown;
            birthYear = ArgsBirthYear;

            totalSurvey++;
            //ID generation
            surveyID = DateTime.Now.ToString(String.Format("{0} - {1:D2} ", DateTime.Now.ToString("yy/MM/dd"), SurveyNum(totalSurvey)));
        }

        //Citizen Info Reading
        //Member Variable Property <!>
        public string FirstName { 
            get { return firstName; }}
        public string Surname { 
            get { return surname; }}
        public int BirthYear { 
            get { return birthYear; }}
        public string TownID {
            get { return townID; }}
        public string SurveyID{
            get { return surveyID; }}

        //Member Method <!>
        private static int SurveyNum(int TotalSurvey){ 
            return TotalSurvey;
        }

        private static void UpdateDataBase()
        {
            
        }
    }
}
