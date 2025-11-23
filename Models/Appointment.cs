using System;
using System.ComponentModel.DataAnnotations;

namespace BeautyParlour.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select a service")]
        public string ServiceType { get; set; }

        [Required(ErrorMessage = "Please select appointment date")]
        public DateTime AppointmentDate { get; set; }

        public string Message { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
