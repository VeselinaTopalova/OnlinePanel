namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateSurveyInputModel
    {
        public string Name { get; set; }

        public IEnumerable<CreateQuestionInputModel> Questions { get; set; }

        public IEnumerable<SQAnswerInputModel> Answers { get; set; }
    }
}
