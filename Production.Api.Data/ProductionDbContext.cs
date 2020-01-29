using Microsoft.EntityFrameworkCore;
using Production.Api.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Production.Api.Data
{
   public class ProductionDbContext : DbContext
    {
        public ProductionDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UpdateUser> UpdatedUser { get; set; }
    }
}
