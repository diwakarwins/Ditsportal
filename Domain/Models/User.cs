using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class User:BaseEntity
    {
       [Key]
        public int UserId { get; set; }
        [Column(TypeName = "varchar(50)")] 
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "Datetime")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Password { get; set; }
        [Column(TypeName = "int")]
        public int? Gender { get; set; }
        [Column(TypeName = "int")]
        public int? Designation { get; set; }
        public string Phone { get; set; }
        public string AlternateNumber { get; set; }
        public string? OfficialEmail { get; set; }=null;
        public string Skype { get; set; }
        public string? ResetToken { get; set; }=null;
        public string PAN { get; set; }
        public string? BloodGroup { get; set; }=null;
        public DateTime? DateOfJoining { get; set; }
        public DateTime? DateOfLeaving { get; set; }
      
        public DateTime? LastLoggedIn { get; set; }
        public DateTime? CodeExpired { get; set; }=null;
        [Column(TypeName = "varchar(50)")]
        //public string UserType { get; set; }
        
        public bool IsApproved { get; set; }
        public string CreatedBy{get; set;}

        public int? Code{get; set;}=null;
       
        
    }
}