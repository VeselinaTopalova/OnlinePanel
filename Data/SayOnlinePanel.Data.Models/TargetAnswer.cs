namespace SayOnlinePanel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Common.Models;

    public class TargetAnswer : BaseDeletableModel<int>
    {
        public TargetAnswer()
        {
            this.Users = new HashSet<ApplicationUser>();
            this.TargetUserAnswers = new HashSet<TargetUserAnswer>();
        }

        public string Name { get; set; }

        [Required]
        public int TargetQuestionId { get; set; }

        public virtual TargetQuestion TargetQuestion { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<TargetUserAnswer> TargetUserAnswers { get; set; }
    }
}
