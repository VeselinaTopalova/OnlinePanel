namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateSurveyInputModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int PointsStart { get; set; }

        public int PointsTotal { get; set; }

        public int SampleTotal { get; set; }

        public int SampleFemale { get; set; }

        public int SampleMale { get; set; }

        public IEnumerable<CreateQuestionInputModel> Questions { get; set; }

        //public IEnumerable<SQAnswerInputModel> Answers { get; set; }
    }
}
