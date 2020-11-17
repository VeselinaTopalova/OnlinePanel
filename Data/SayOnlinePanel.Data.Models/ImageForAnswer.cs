namespace SayOnlinePanel.Data.Models
{
    using System;

    using SayOnlinePanel.Data.Common.Models;

    public class ImageForAnswer : BaseModel<string>
    {
        public ImageForAnswer()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int AnswerId { get; set; }

        public virtual Answer Answer { get; set; }

        public string Extension { get; set; }
    }
}
