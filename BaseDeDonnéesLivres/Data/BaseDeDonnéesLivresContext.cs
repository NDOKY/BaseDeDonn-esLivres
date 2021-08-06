using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaseDeDonnéesLivres.Models;

namespace BaseDeDonnéesLivres.Data
{
    public class BaseDeDonnéesLivresContext : DbContext
    {
        public BaseDeDonnéesLivresContext (DbContextOptions<BaseDeDonnéesLivresContext> options)
            : base(options)
        {
        }

        public DbSet<BaseDeDonnéesLivres.Models.Livre> Livre { get; set; }
    }
}
