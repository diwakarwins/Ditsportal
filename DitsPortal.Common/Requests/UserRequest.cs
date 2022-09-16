using System.ComponentModel.DataAnnotations;

namespace DitsPortal.Common.Requests
{
    public class UserLoginRequest
    {
        /// <summary>
        /// Give Email Id
        /// </summary>
        [Required]
        public string Email { get; set; }

        public int UserId { get; set; }
        /// <summary>
        /// <summary>
        /// Give Your Min 8 Length Password
        /// </summary>
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }

    public class UserLogoutRequest
    {
        /// <summary>
        /// UserId
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// User email
        /// </summary>
        public string Email { get; set; }
    }

    public class AddUserRole
    {
        /// <summary>
        /// Give Email Id
        /// </summary>
        public int RoleId { get; set; }
    }
      public class UserRegisterRequest
    {
        /// <summary>
        /// Set User Id On Edit Time
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// First Name Of User
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name Of User
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        ///Set Date Of Birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Full Name Of User
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Set Gender Id For User
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// Designation Id For User Like Designer,Junior Engineer 
        /// </summary>
        public int? Designation { get; set; }
        /// <summary>
        /// Phone Number Of User 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Any Alternate Number Of User 
        /// </summary>
        public string AlternateNumber { get; set; }
        /// <summary>
        /// Skype Id Of User 
        /// </summary>
        public string Skype { get; set; }
        /// <summary>
        /// PAN Card  Number Id Of User 
        /// </summary>
        public string PAN { get; set; }
        /// <summary>
        /// Blood Group Id For User 
        /// </summary>
        public string? BloodGroup { get; set; }
        /// <summary>
        ///User Date Of joining  
        /// </summary>
        public DateTime? DateOfjoining { get; set; }
        /// <summary>
        ///User Date Of Leaving  
        /// </summary>
        public DateTime? DateOfLeaving { get; set; }
        /// <summary>
        ///Any Media Id 
        /// </summary>
        // public int? MediaId { get; set; }
        /// <summary>
        ///Min 8 Length Password Of User
        /// </summary>
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        /// <summary>
        ///Email Id Of User
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        ///Profile Image Of User
        /// </summary>
        // public string ProfileImage { get; set; }
        /// <summary>
        ///Type Of Image Like Png , Jpg
        /// </summary>
        // public string ImageType { get; set; }
        /// <summary>
        /// Set True and False To Approved Creating Account
        /// </summary>
        public bool IsApproved { get; set; }
        public string? OfficialEmail{get; set;}
        /// <summary>
        /// Set Multiple Role's Id For User
        /// </summary>
        // public List<AddUserRole> addUserRoles { get; set; }
        /// <summary>
        /// Id of the logged user
        /// </summary>
        public string ActionBy { get; set; }
    }
      public class ChangePasswordRequest
    {
        [Required]
        public string UserName { get; set; }
        /// <summary>
        ///Email Id Of User
        /// </summary>
        [Required]
        public string Email { get; set; }
        /// <summary>
        ///Min 8 Length Password 
        /// </summary>
        [Required]
        [MinLength(8)]
        public string NewPassword { get; set; }

    }
     public class ForgotPasswordRequest
    {
        [Required]
        public string? Email { get; set; }
        
        
    }
   
}