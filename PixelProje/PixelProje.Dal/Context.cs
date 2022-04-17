using Microsoft.EntityFrameworkCore;
using PixelProje.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Dal
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Abone>Abone { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
    }
}
