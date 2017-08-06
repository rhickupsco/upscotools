using System;

namespace UpscoSurveys
{
    public class Surveys
    {
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SurveyCreator { get; set; }
    }
}