using System;
using System.Collections.Generic;
using System.Text;

namespace SayOnlinePanel.Data.Models
{
    public class TargetSyrveyUserInfo
    {
        public int TargetSurveyId { get; set; }

        public virtual TargetSurvey TargetSurvey { get; set; }

        public int UserInfoId { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
