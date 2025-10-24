using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DatabaseTask.Data
{
    class DatabaseTaskDbContext : DbContext
    {
        public class DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options){}

    public DbSet<Employee> Employees { get; set; }
    }
}
