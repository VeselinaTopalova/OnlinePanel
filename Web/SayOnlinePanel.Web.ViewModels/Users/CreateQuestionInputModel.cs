namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateQuestionInputModel
    {
        //[Required]
        [Display(Name = "QuestionName")]
        public string Name { get; set; }

        public IEnumerable<SQAnswerInputModel> Answers { get; set; }
    }
}
