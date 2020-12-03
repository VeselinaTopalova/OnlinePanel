namespace SayOnlinePanel.Web.ViewModels.UserInfos
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateUserInfoInputModel
    {
        [Required]
        //public Gender Gender { get; set; }
        public string Gender { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }

    //public enum Gender
    //{
    //    Male,

    //    Female,
    //}
}
