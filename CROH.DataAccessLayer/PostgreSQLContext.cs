using CROH.DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CROH.DataAccessLayer
{
    public class PostgreSQLContext : DbContext, IDBContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // To do for PostgreSql
        }
    }
}
