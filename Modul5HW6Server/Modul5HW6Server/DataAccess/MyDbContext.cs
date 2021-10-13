using Microsoft.EntityFrameworkCore;
using Modul5HW6Server.DataAccess.DataConfigs;
using Modul5HW6Server.ModelsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul5HW6Server.DataAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> dbContextOptions) 
            : base(dbContextOptions)
        {
        }

        public DbSet<CustomerView> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.ApplyConfiguration(new CustomerConfig());
        }
    }
}
