namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    //ok
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class EditSurveyInputModel : IMapFrom<TargetSurvey>
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [Display(Name = "Survey Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public int PointsStart { get; set; }

        public List<EditQuestionInputModel> TargetQuestions { get; set; }
    }

    public class EditQuestionInputModel : IMapFrom<TargetQuestion>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TargetQuestionType TargetQuestionType { get; set; }

        public List<EditAnswerInputModel> TargetAnswers { get; set; }
    }

    public class EditAnswerInputModel : IMapFrom<TargetAnswer>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
