using System.ComponentModel.DataAnnotations;

namespace StageSync.Models
{
    public class UserModel
    {
        public int PerformerId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string StageName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(40)]
        public string BandAffiliation { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 7)]
        public string ContactNumber { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}