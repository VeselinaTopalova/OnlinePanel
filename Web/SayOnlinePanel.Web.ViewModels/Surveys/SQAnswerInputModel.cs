namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.ComponentModel.DataAnnotations;

    public class SQAnswerInputModel
    {
        //[Required]
        [Display(Name = "AnswerName")]
        public string Name { get; set; }
    }
}
