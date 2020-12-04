namespace SayOnlinePanel.Web.ViewModels.UserInfos
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateUserInfoInputModel
    {
        [Required]
        public Gender Gender { get; set; }

        [Required]
        public Town Town { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }

    public enum Gender
    {
        Male,

        Female,
    }

    public enum Town
    {
        Capital = 1,

        RegionalCapital = 2,

        SmallTown = 3,

        Countri = 4,
    }
}
