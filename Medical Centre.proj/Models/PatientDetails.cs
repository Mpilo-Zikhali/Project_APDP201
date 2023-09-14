using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Medical_Centre.proj.Models
{
    public class PatientDetails
    {[Key]
        [Required(ErrorMessage = "Enter your student or staff number")]
        [MaxLength(8)]
        [DisplayName("Student/Staff Number")]
        public string SNumber { get; set; }
        public role Role { get; set; }
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your name")]
       
        public string Surname { get; set; }
        [DisplayName("Gender")]
        public Gender gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName ("Phone Number")]
        public int PhoneNumber { get; set; }
        [Required]
        
        public UniV University { get; set; }
        [Required]
        [DisplayName("Chronic illness")]
        public Chronic Cillness{ get; set;}
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Create Password")]

        public string CreatePassword { get; set; }
        [Compare("CreatePassword")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

     

        public enum role
        {
            Student,
            Staff
        }

        public enum UniV
        {
            Durban_University_Of_Technology,
            Univerity_Of_KwaZulu_Natal,
            Mangosuthu_University_Of_Technology
        }
        public enum Chronic
        {
                Obesity,
                High_Blood_pressure,
                Cancer,
                HIV_or_AIDS,
                Heart_Disease,
                Chronic_Kidney
        }
        public enum Gender
        {
            Female,
            Male,
            Other
        }
    }

   
}