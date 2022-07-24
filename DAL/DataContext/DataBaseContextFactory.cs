using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataContext
{
    class DataBaseContextFactory : IDesignTimeDbContextFactory<DbHamedtt>
    {
        public DbHamedtt CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var opsBuilder = new DbContextOptionsBuilder<DbHamedtt>();
            opsBuilder.UseSqlServer(appConfig.sqlConnectionString);
            return new DbHamedtt(opsBuilder.Options);
        }
    }
}
