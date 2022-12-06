using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SmartShades.EntityFrameworkCore
{
    public static class SmartShadesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SmartShadesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SmartShadesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
