using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace DAL.DataContext
{
   public class DbHamedtt : DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                settings = new AppConfiguration();
                opsBulider = new DbContextOptionsBuilder<DbHamedtt>();
                opsBulider.UseSqlServer(settings.sqlConnectionString);
                dbOptions = opsBulider.Options;
            }

            public DbContextOptionsBuilder<DbHamedtt> opsBulider { get; set; }
            public DbContextOptions<DbHamedtt> dbOptions { get; set; }
            private AppConfiguration settings { get; set; }
        }

        public static OptionsBuild ops = new OptionsBuild();

        public DbHamedtt(DbContextOptions<DbHamedtt> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
