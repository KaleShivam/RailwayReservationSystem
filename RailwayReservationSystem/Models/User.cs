﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RailwayReservationSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } //primary key

        

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "User Name")]
        [StringLength(50)]
        public string Name { get; set; }

        

        [Required(ErrorMessage = "Email is required")]
        [DisplayName("EmailId")]
        [EmailAddress(ErrorMessage = "Invalid Email Id")]
        public string Email_id { get; set; }

        

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
