using System;

namespace MyCompany.Data.Entities.Users
{
    public class User : BaseEntity
    {
        public string AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IPAddress { get; set; }

        public Permission Permission { get; set; }
        public Role Role { get; set; }
    }
}
