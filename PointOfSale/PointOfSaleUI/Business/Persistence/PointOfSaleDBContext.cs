using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Persistence
{
    internal class PointOfSaleDBContext : DbContext
    {

        public PointOfSaleDBContext() : base("Connection") { }

        public DbSet<User> Users { get; set; }

    }
}
