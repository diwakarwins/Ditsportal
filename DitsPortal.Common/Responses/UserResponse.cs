namespace DitsPortal.Common.Responses
{
    public class UserResponse
    {
         public string token { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Message{get; set;}
        // public List<UserRoles> Roles { get; set; }
    }
}