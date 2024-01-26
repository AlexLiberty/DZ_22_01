using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_22_01
{
    internal class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Train> Trains { get; set; }
    }
}
