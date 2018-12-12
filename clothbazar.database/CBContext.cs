using clothbazar.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothbazar.database
{
   public class CBContext:DbContext,IDisposable
    {
        public CBContext():base("Default")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
