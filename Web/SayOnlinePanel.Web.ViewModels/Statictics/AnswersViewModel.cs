namespace SayOnlinePanel.Web.ViewModels.Statictics
{
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;
    using System;
    using System.Runtime.Serialization;

    public class AnswersViewModel : IMapFrom<Answer>
    {
        public string Name { get; set; }
        public int Count { get; set; }
        //public AnswersViewModel(string label, double y)
        //{
        //    this.Label = label;
        //    this.Y = y;
        //}

        ////Explicitly setting the name to be used while serializing to JSON.
        //[DataMember(Name = "label")]
        //public string Label = "";

        ////Explicitly setting the name to be used while serializing to JSON.
        //[DataMember(Name = "y")]
        //public Nullable<double> Y = null;

    }
}

