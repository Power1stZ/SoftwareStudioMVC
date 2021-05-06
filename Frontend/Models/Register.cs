using System;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class Register
    {
        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบถ้วน")]
        [StringLength(50, ErrorMessage = "ชื่อสูงสุด 50 ตัวอักษร")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบถ้วน")]
        [StringLength(50, ErrorMessage = "ชื่อสูงสุด 50 ตัวอักษร")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบถ้วน")]
        [StringLength(8, ErrorMessage = "รหัสนักศึกษา 8 หลัก", MinimumLength = 8)]
        public string studentNumber { get; set; }

        [EmailAddress(ErrorMessage = "อีเมลไม่ถูกต้อง")]
        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบถ้วน")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "8 ถึง 50 ตัวอักษร", MinimumLength = 8)]
        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบถ้วน")]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "รหัสผ่านไม่ตรงกัน")]
        [StringLength(50, ErrorMessage = "8 ถึง 50 ตัวอักษร", MinimumLength = 8)]
        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบถ้วน")]
        public string confirmPassword { get; set; }
    }
}