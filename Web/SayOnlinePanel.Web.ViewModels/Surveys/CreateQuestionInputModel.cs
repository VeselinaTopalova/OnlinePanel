namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateQuestionInputModel
    {
        [Required]
        [Display(Name = "QuestionName")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "QuestionType")]
        public string QuestionType { get; set; }

        public IEnumerable<SQAnswerInputModel> Answers { get; set; }
    }
}
