namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class EditSurveyInputModel : IMapFrom<Survey>
    {
        public int Id { get; set; }

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

        public List<EditQuestionInputModel> Questions { get; set; }
    }

    public class EditQuestionInputModel : IMapFrom<Question>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public QuestionType QuestionType { get; set; }

        public List<EditAnswerInputModel> Answers { get; set; }
    }

    public class EditAnswerInputModel : IMapFrom<Answer>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
