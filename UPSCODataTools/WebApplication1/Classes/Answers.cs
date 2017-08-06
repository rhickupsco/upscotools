using System;

namespace UpscoSurveys
{
    public class Answers
    {
        public enum QuestionType
        {
            Number,
            Letter,
            Date,
            Day,
            Time,
            YorN,
            TorF,
            Freeform
        }

        public int NumberAnswer { get; set; }
        public char LetterAnswer { get; set; }
        public DateTime DateAnswer { get; set; }
        public DayOfWeek DayAnswer { get; set; }
        public DateTime TimeAnswer { get; set; }
        public char YesOrNoAnswer { get; set; }
        public bool TrueFalseAnswer { get; set; }
        public string FreeformAnswer { get; set; }

    }
}