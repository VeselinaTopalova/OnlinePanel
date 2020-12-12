using System;
using System.Collections.Generic;
using System.Text;

namespace SayOnlinePanel.Data.Models
{
    public class SurveyUserInfo
    {
        public SurveyUserInfo()
        {
            this.isComplete = false;
        }
        public int SurveyId { get; set; }

        public virtual Survey Survey { get; set; }

        public int UserInfoId { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        public bool isComplete { get; set; }
    }
}
