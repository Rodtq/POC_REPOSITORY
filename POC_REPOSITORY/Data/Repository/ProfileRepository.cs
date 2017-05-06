using POC_REPOSITORY.Data.Models;
using POC_REPOSITORY.Data.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POC_REPOSITORY.Data.Repository
{
    public class ProfileRepository : GenericRepository<Profile> ,IProfileRepository//here is the contract you have to implement for custom methods
    {
        public ProfileRepository(DbContext rContext):base(rContext) 
        {

        }
    }
}