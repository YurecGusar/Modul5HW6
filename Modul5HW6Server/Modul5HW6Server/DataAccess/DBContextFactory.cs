using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul5HW6Server.DataAccess
{
    public class DBContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var dbContextOption = new DbContextOptionsBuilder<MyDbContext>();
            dbContextOption.UseSqlServer("Server = localhost,1433; Database = Modul5HW6; User = sa; Password = Passw0rd;");
            return new MyDbContext(dbContextOption.Options);
        }
    }
}
