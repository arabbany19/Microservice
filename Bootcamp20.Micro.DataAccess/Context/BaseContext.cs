using Bootcamp20.Micro.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp20.Micro.DataAccess.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("Bootcamp20.Micro") { }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
