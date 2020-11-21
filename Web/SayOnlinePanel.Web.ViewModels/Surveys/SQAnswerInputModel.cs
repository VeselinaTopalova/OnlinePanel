namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.ComponentModel.DataAnnotations;

    public class SQAnswerInputModel
    {
        [Required]
        public string Name { get; set; }
    }
}
