using POC_REPOSITORY.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POC_REPOSITORY.Data.DatabaseContext
{
    public class DataContext : DbContext
    {

        public DataContext(string databaseName) : base(databaseName)
        {
        }
        DbSet<User> Users { get; set; }
        DbSet<Profile> Profiles { get; set; }
    }
}