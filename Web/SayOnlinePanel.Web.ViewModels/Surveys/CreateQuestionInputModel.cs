namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class CreateQuestionInputModel
    {
        [Required]
        [Display(Name = "Question Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Question Type")]
        public string QuestionType { get; set; }

        public IFormFile Image { get; set; }

        public IEnumerable<SQAnswerInputModel> Answers { get; set; }
    }
}
