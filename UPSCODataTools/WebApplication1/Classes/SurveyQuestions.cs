
namespace UpscoSurveys
{
    public class SurveyQuestions
    {
        public int SurveyId { get; set; }
        public int QuestionNumber { get; set; }    
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public Answers AnswerTypeExpected { get; set; }
    }
}