namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    //ok
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateSurveyInputModel
    {
        public CreateSurveyInputModel()
        {
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today;
        }

        [Required]
        [MinLength(3)]
        [Display(Name = "Target Survey Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        //public int PointsStart { get; set; }

        public IEnumerable<CreateQuestionInputModel> Questions { get; set; }
    }
}
