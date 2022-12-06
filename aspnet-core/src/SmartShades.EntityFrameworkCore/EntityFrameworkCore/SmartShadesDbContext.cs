using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SmartShades.Authorization.Roles;
using SmartShades.Authorization.Users;
using SmartShades.MultiTenancy;

namespace SmartShades.EntityFrameworkCore
{
    public class SmartShadesDbContext : AbpZeroDbContext<Tenant, Role, User, SmartShadesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SmartShadesDbContext(DbContextOptions<SmartShadesDbContext> options)
            : base(options)
        {
        }
    }
}
