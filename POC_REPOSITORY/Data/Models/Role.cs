using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC_REPOSITORY.Data.Models
{
    public class Role
    {
        public Role()
        {
            Profiles = new HashSet<Profile>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual HashSet<Profile> Profiles { get; set; }
    }
}