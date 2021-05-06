using System;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class Login
    {
        [RegularExpression("^(.+@.+[.].+)$", ErrorMessage = "อีเมลไม่ถูกต้อง")]
        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบถ้วน")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "8 ตัวขึ้นไป", MinimumLength = 8)]
        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบถ้วน")]
        public string password { get; set; }
    }
}