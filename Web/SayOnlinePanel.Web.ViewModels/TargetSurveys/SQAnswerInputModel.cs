namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    using System.ComponentModel.DataAnnotations;

    public class SQAnswerInputModel
    {
        [Required]
        [Display(Name = "Answer Name")]
        public string Name { get; set; }
    }
}
