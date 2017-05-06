using POC_REPOSITORY.Data.Repository.Contracts;
using POC_REPOSITORY.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC_REPOSITORY.Bussiness
{
    public class RegisterManager : IRegisterManager
    {
        private IUnitOfWork _uow;
        public RegisterManager(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public void AddUser(UserRegisterViewModel user)
        {
            _uow.UserRepository.Add(new Data.Models.User
            {
                Name = user.Name
            });
            _uow.Save();
        }

        public void AddProfile(ProfileRegisterViewModel profile)
        {
            _uow.ProfileRepository.Add(new Data.Models.Profile
            {
                Name = profile.Name
            });
            _uow.Save();
        }



        public void AddRole(RoleRegisterViewModel role)
        {
            _uow.RoleRepository.Add(new Data.Models.Role
            {
                Name = role.Name
            });
            _uow.Save();
        }

    }
}