using System.ComponentModel.DataAnnotations;

namespace InternshipApi.DTOs
{
    public class UpdateInstitutionDto
    {
        [MaxLength(200, ErrorMessage = "Institution name can't be more than 200 characters")]
        [MinLength(2, ErrorMessage = "Institution name can't be less than 2 characters")]
        public string? Name { get; set; }

        [MaxLength(100, ErrorMessage = "Address can't be more than 100 characters")]
        public string? Address { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        [MaxLength(50, ErrorMessage = "Phone number can't be more than 50 characters")]
        public string? PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        [MaxLength(150, ErrorMessage = "Email can't be more than 150 characters")]
        public string? Email { get; set; }
        [MaxLength(100, ErrorMessage = "Type can't be more than 100 characters")]
        public string? Type { get; set; }

        [Range(1800, 2100, ErrorMessage = "Founded year must be a valid year")]
        public int? FoundedYear { get; set; }

        [MaxLength(1000, ErrorMessage = "Description can't be more than 1000 characters")]
        public string? Description { get; set; }
    }
}
