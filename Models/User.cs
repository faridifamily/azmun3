using System.ComponentModel.DataAnnotations;

namespace azmoooon.Models
{
    public class User
    {

        [Required(ErrorMessage = "ورود ایمیل اجباری است")]
        public string Email { get; set; }

        [MinLength(11, ErrorMessage = "طول موبایل باید 11 رقم باشد")]
        [MaxLength(11, ErrorMessage = "طول موبایل باید 11 رقم باشد")]
        public string Mobile { get; set; }
    }
}
