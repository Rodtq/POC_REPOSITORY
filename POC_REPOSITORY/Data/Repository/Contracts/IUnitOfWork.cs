using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_REPOSITORY.Data.Repository.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get;}
        IProfileRepository ProfileRepository { get;}
        IRoleRepository RoleRepository { get;}
        void Save(bool validate = true);
    }
}
