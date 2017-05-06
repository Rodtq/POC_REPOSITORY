using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC_REPOSITORY.Data.Models
{
    public class Profile
    {
        public Profile()
        {
            Users = new HashSet<User>();
            Roles = new HashSet<Role>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual HashSet<Role> Roles { get; set; }
        public virtual HashSet<User> Users { get; set; }
    }
}