using POC_REPOSITORY.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_REPOSITORY.Bussiness
{
    public interface IRegisterManager
    {
        void AddUser(UserRegisterViewModel user);
        void AddProfile(ProfileRegisterViewModel profile);
        void AddRole(RoleRegisterViewModel role);
    }
}
