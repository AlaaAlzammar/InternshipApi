using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternshipApi.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Student Name is required")]
        [MaxLength(50, ErrorMessage = "Student Name can't be more than 200 characters")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(150, ErrorMessage = "Email can't be more than 150 characters")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Student number is required")]
        [MaxLength(50, ErrorMessage = "Student number can't be more than 50 characters")]
        public string? Level { get; set; }
        public string? PhoneNumber { get; set; }
        [MaxLength(150, ErrorMessage = "Location can't be more than 150 characters")]
        public string? Location { get; set; }
        [MaxLength(150, ErrorMessage = "University can't be more than 150 characters")]
        public string? University { get; set; }
        [MaxLength(150, ErrorMessage = "Major can't be more than 150 characters")]
        public string? Major { get; set; }


        public decimal? GPA { get; set; }
        [MaxLength(1000, ErrorMessage = "Bio can't be more than 1000 characters")]
        public string? Bio { get; set; }

        [MaxLength(300, ErrorMessage = "LinkedIn URL can't be more than 300 characters")]
        public string? LinkedinUrl { get; set; }

        [MaxLength(300, ErrorMessage = "GitHub URL can't be more than 300 characters")]
        public string? GithubUrl { get; set; }
        [MaxLength(300, ErrorMessage = "Portfolio URL can't be more than 300 characters")]
        public string? PortfolioUrl { get; set; }
        [MaxLength(500, ErrorMessage = "CV path can't be more than 500 characters")]
        public string? CVPath { get; set; }
        public string? ProfileImagePath { get; set; }
        // نخزن المهارات كـ JSON string بعمود واحد، وبنعرضها كـ List<string> بالكود
        public string? SkillsJson { get; set; }

        [NotMapped]
        public List<string> Skills
        {
            get => string.IsNullOrEmpty(SkillsJson)
                ? new List<string>()
                : System.Text.Json.JsonSerializer.Deserialize<List<string>>(SkillsJson) ?? new List<string>();
            set => SkillsJson = System.Text.Json.JsonSerializer.Serialize(value);
        }



        //UserID FK
        [Required(ErrorMessage = "User account is required")]
        public string UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public AspNetUser User { get; set; }



        public ICollection<Application> Applications { get; set; } = new List<Application>();

       



    }
}
