﻿//using RailwayReservationSystem.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RailwayReservationSystem.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; } //primary key

        
        [ForeignKey("TrainId")]
        public int TrainId { get; set; }

        

        [Required(ErrorMessage = "Enter Admin Name")]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        

        [Required(ErrorMessage = "Enter Email Id")]
        [DisplayName("EmailId")]
        [EmailAddress]
        public string Email { get; set; }

        

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
        ErrorMessage = "Password should be between 8 to 10 characters, and contain at least one lowercase letter, one uppercase letter, one numeric digit, and one special character.")]
        public string Password { get; set; }

        

        [JsonIgnore]
        public Train Train { get; set; }
    }
}
