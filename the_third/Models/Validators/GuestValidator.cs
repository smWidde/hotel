using System.ComponentModel.DataAnnotations;

namespace the_third.Models.Validators
{
    public class GuestValidator
    {
        public static ValidationResult CheckFIO(string FIO)
        {
            string[] names = FIO.Split(' ');
            foreach(string item in names)
            {
                if(char.IsLower(item[0]))
                {
                    return new ValidationResult("Все слова должны быть с большой буквы!");
                }
                foreach (char subitem in item)
                {
                    if(!char.IsLetter(subitem))
                    {
                        return new ValidationResult("Должны быть только буквы");
                    }
                }
            }
            return ValidationResult.Success;
        }
        public static ValidationResult CheckPhoneNumber(string Phone)
        {
            string modifiedPhone = Phone.Remove(5, 1);
            modifiedPhone = modifiedPhone.Remove(8, 1);
            modifiedPhone = modifiedPhone.Remove(10, 1);
            if (modifiedPhone.Length==12)
            {

                foreach (char item in modifiedPhone)
                {
                    if (!char.IsDigit(item))
                    {
                        return new ValidationResult("Должны быть только цифры");
                    }
                }
            }
            else
            {
                return new ValidationResult("Номер должен быть длиной в 12 (начинается с 380)");
            }
            return ValidationResult.Success;
        }
    }
}