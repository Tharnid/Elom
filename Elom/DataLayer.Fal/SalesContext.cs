using Fal.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Fal
{
    public class SalesContext : DbContext
    {
        public SalesContext()
            : base("DefaultConnection")
        {

        }

        public IDbSet<SalesOrder> SalesOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SalesOrderConfiguration());
        }
    }
}
