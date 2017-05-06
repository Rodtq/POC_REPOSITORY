using POC_REPOSITORY.Data.DatabaseContext;
using POC_REPOSITORY.Data.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POC_REPOSITORY.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            _context = new DataContext("POC_REPOSITORY_DATABASE");
        }
        private DbContext _context;
        private bool _disposed = false;
        private IUserRepository _userRepository;
        private IProfileRepository _profileRepository;
        private IRoleRepository _roleRepository;

        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_context);

        public IProfileRepository ProfileRepository => _profileRepository ?? new ProfileRepository(_context);

        public IRoleRepository RoleRepository => _roleRepository ?? new RoleRepository(_context);

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save(bool validate = true)
        {
            _context.SaveChanges();
        }
    }
}