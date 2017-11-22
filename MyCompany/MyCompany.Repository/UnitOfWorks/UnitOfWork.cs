using MyCompany.Data;
using MyCompany.Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private MyCompanyContext _context;
        public IRepository<User> UserRepository { get; private set; }
        public IRepository<Role> RoleRepository { get; private set; }
        public IRepository<UserProfile> UserProfileRepository { get; private set; }
        public IRepository<Permission> PermissionRepository { get; private set; }

        public UnitOfWork(MyCompanyContext context)
        {
            _context = context;
            InitializeRepository();
        }

        private void InitializeRepository()
        {
            UserRepository = new GenericRepository<User, MyCompanyContext>(_context);
            RoleRepository = new GenericRepository<Role, MyCompanyContext>(_context);
            PermissionRepository = new GenericRepository<Permission, MyCompanyContext>(_context);
            UserProfileRepository = new GenericRepository<UserProfile, MyCompanyContext>(_context);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            //TODO:
        }
    }
}
