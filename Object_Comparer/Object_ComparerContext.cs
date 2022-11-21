using Microsoft.EntityFrameworkCore;
using Object_Comparer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Comparer {
    public class Object_ComparerContext : DbContext{
        private const string connectionString = "";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<SomeObject> SomeObjects { get; set; }
        public DbSet<SomeObjectFieldChangeLog> SomeObjectFieldChangeLogs { get; set; }
    }
}
