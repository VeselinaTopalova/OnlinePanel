namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Models;

    public class CreateQuestionInputModel
    {
        [Required]
        public string Name { get; set; }

        //[Required]
        //public QuestionType QuestionType { get; set; }
        [Required]
        [Display(Name = "QuestionType")]
        public string QuestionType { get; set; }

        public IEnumerable<SQAnswerInputModel> Answers { get; set; }

    }
    
}
