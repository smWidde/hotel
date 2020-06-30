using System.ComponentModel.DataAnnotations;

namespace the_third
{
    public class GuestResponse
    {
        [Required]
        [RegularExpression(@"[А-Я]{1}[а-я]+", ErrorMessage="Имя, да так чтоб православно")]
        public string FIO { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{5}-[0-9]{3}(-[0-9]{2}){2}", ErrorMessage = "Номер, да так чтоб только числа и православно")]
        public string PhoneNumber { get; set; }
        public string ChosenRoomNumber { get; set; }
    }
}