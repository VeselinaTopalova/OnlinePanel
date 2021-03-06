﻿namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PeopleSelectionViewModel
    {
        public SingleSurveyViewModel Survey;

        public List<AnsweredQuestion> AnsweredQuestions { get; set; }

        public PeopleSelectionViewModel()
        {
            this.AnsweredQuestions = new List<AnsweredQuestion>();

        }
    }

    public class InputAnswer
    {
        public int Id { get; set; }

        public string Input { get; set; }

        public InputAnswer()
        {
            this.Id = 0;
            this.Input = "";
        }
    }

    public class AnsweredQuestion
    {
        [Required]
        public int Id { get; set; }

        public List<InputAnswer> InputAnswers { get; set; }

        public List<int> SelectedAnswerIds { get; set; }

        public AnsweredQuestion()
        {
            this.InputAnswers = new List<InputAnswer>();
            this.SelectedAnswerIds = new List<int>();
        }

    }
}
