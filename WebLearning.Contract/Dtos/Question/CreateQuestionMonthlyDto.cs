﻿namespace WebLearning.Contract.Dtos.Question
{
    public class CreateQuestionMonthlyDto
    {
        public Guid Id { get; set; }
        public Guid QuizMonthlyId { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }

        public int Point { get; set; }
        public string Alias { get; set; }
        public string Code
        {
            get; set;
        }
        public string CodeQuiz
        {
            get; set;
        }
        public DateTime DateCreated
        {
            get; set;
        }
    }
}
