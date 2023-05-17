using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RailwayReservationSystem.Models;

namespace RailwayReservationSystem.Models
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; } //primary key

        

        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; } //foreign key

        

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        


        

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [DisplayName("Phone Number")]
        public string Phone_no { get; set; }

       

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        [DisplayName("Age")]
        public int age { get; set; }

        

        [Required(ErrorMessage = "Gender is required")]
        [DisplayName("Gender")]
        public string gender { get; set; }

        

        [JsonIgnore]
        public User User { get; set; }
    }
}
