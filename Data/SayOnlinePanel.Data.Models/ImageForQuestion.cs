namespace SayOnlinePanel.Data.Models
{
    using System;

    using SayOnlinePanel.Data.Common.Models;

    public class ImageForQuestion : BaseModel<string>
    {
        public ImageForQuestion()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }

        public string Extension { get; set; }
    }
}
