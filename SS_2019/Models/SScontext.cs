using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_2019.Models
{
    public class SScontext : DbContext
    {
        public SScontext(DbContextOptions<SScontext> options) : base(options) { }

        public SScontext() { }

        public DbSet<Dht_11_h> Humidity { get; set; }

        public DbSet<Dht_11_t> Temperature { get; set; }

        public DbSet<Ky_026> FireDetection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
        }
    }
}
