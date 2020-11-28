using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SayOnlinePanel.Web.ViewModels.Users
{
    public class PeopleSelectionViewModel
    {
        public List<SelectAnswerEditorViewModel> Answers { get; set; }
        public PeopleSelectionViewModel()
        {
            this.Answers = new List<SelectAnswerEditorViewModel>();
        }


        public IEnumerable<int> getSelectedIds()
        {
            // Return an Enumerable containing the Id's of the selected people:
            return (from p in this.Answers where p.Selected select p.Id).ToList();
        }
    }
}
