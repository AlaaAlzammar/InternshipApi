using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InternshipApi.DTOs
{
   
        public class UpdateStudentDto
        {
        [MaxLength(50, ErrorMessage = "Student Name can't be more than 50 characters")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        [MaxLength(150, ErrorMessage = "Email can't be more than 150 characters")]
        public string? Email { get; set; }

        [MaxLength(50, ErrorMessage = "Level can't be more than 50 characters")]
        public string? Level { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string? PhoneNumber { get; set; }

        [MaxLength(150, ErrorMessage = "Location can't be more than 150 characters")]
        public string? Location { get; set; }

        [MaxLength(150, ErrorMessage = "University can't be more than 150 characters")]
        public string? University { get; set; }

        [MaxLength(150, ErrorMessage = "Major can't be more than 150 characters")]
        public string? Major { get; set; }

        [Range(0, 100.0, ErrorMessage = "GPA must be between 0 and 100")]
        public decimal? GPA { get; set; }

        [MaxLength(1000, ErrorMessage = "Bio can't be more than 1000 characters")]
        public string? Bio { get; set; }

        [Url(ErrorMessage = "Invalid LinkedIn URL")]
        [MaxLength(300)]
        public string? LinkedinUrl { get; set; }

        [Url(ErrorMessage = "Invalid GitHub URL")]
        [MaxLength(300)]
        public string? GithubUrl { get; set; }

        [Url(ErrorMessage = "Invalid portfolio URL")]
        [MaxLength(300)]
        public string? PortfolioUrl { get; set; }

        public List<string>? Skills { get; set; }
    

        }
    
}
