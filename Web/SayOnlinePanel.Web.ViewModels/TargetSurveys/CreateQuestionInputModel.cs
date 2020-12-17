namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateQuestionInputModel
    {
        [Required]
        [Display(Name = "Question Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Question Type")]
        public string QuestionType { get; set; }

        public IEnumerable<SQAnswerInputModel> Answers { get; set; }
    }
}
