namespace SayOnlinePanel.Web.ViewModels.UserInfos
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Models;

    public class CreateUserInfoInputModel
    {
        public CreateUserInfoInputModel()
        {
            this.Birthday = DateTime.Today;
        }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public Town Town { get; set; }

        [Required]
        [DataType(DataType.Date)]
        //[Range(typeof(DateTime), "1/1/1900", "1/1/2012", ErrorMessage = "Date is out of Range")]
        public DateTime Birthday { get; set; }
    }
}
