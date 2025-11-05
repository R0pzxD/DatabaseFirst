using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<passengers> passengers { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Pilots> Pilots { get; set; }
        public DbSet<Planes> Planes { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
    }
}
