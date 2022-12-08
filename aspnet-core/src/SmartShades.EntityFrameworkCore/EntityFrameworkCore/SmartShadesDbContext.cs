using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SmartShades.Authorization.Roles;
using SmartShades.Authorization.Users;
using SmartShades.MultiTenancy;
using SmartShades.Domains.Homes;
using SmartShades.Domains.Rooms;
using SmartShades.Domains.Shades;
using SmartShades.Domains.Schedules;
using SmartShades.Domains.Blocks;

namespace SmartShades.EntityFrameworkCore
{
    public class SmartShadesDbContext : AbpZeroDbContext<Tenant, Role, User, SmartShadesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Home> Homes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Shade> Shades { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Block> Blocks { get; set; }

        public SmartShadesDbContext(DbContextOptions<SmartShadesDbContext> options)
            : base(options)
        {
        }
    }
}
