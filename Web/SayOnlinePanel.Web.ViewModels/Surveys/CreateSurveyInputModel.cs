namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateSurveyInputModel
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "SurveyName")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public int PointsStart { get; set; }

        public int PointsTotal { get; set; }

        [Range(typeof(int), "1", "10000")]
        public int SampleTotal { get; set; }

        public int SampleFemale { get; set; }

        public int SampleMale { get; set; }

        public IEnumerable<CreateQuestionInputModel> Questions { get; set; }
    }
}
