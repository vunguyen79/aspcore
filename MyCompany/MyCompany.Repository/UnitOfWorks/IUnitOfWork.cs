using MyCompany.Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Repository.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UserRepository { get; }
        IRepository<Role> RoleRepository { get; }
        IRepository<Permission> PermissionRepository { get; }
        IRepository<UserProfile> UserProfileRepository { get; }
        void Commit();
        Task CommitAsync();
    }
}
