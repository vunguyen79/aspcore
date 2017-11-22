using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Data.Entities.Users
{
    public class UserProfile : BaseEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvataUrl { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}
