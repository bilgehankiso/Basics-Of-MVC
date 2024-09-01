using System.ComponentModel.DataAnnotations;

namespace mvctrainings.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "First Name is Required")]
        public string? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "Last Name is Required")]
        public string? LastName { get; set; } = String.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}