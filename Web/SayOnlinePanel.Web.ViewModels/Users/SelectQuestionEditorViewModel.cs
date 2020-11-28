using System;
using System.Collections.Generic;
using System.Text;

namespace SayOnlinePanel.Web.ViewModels.Users
{
    public class SelectQuestionEditorViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<SelectAnswerEditorViewModel> SelectAnswers{ get; set; }
    }
}
