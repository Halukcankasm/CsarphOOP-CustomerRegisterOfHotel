using CROH.DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CROH.DataAccessLayer
{
    public interface IDBContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
