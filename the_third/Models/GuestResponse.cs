using System.ComponentModel.DataAnnotations;

namespace the_third.Models
{
    public class GuestResponse
    {
        [Required]
        [CustomValidation(typeof(the_third.Models.Validators.GuestValidator), "CheckFIO")]
        public string FIO { get; set; }
        [Required]
        [CustomValidation(typeof(the_third.Models.Validators.GuestValidator), "CheckPhoneNumber")]
        public string PhoneNumber { get; set; }
        public string ChosenRoomNumber { get; set; }
    }
}