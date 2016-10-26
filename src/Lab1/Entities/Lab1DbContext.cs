using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Entities
{
    public class Lab1DbContext : DbContext
    {
        public Lab1DbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<ContractItem> ContractItems { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
