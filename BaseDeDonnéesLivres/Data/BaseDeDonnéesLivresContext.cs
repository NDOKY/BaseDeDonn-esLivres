using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using BaseDeDonnéesLivres.Models;

namespace BaseDeDonnéesLivres.Data
{
    public class BaseDeDonnéesLivresContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
    {

        private readonly DbContextOptions _options;

        public BaseDeDonnéesLivresContext (DbContextOptions<BaseDeDonnéesLivresContext> options)
            : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<BaseDeDonnéesLivres.Models.Livre> Livre { get; set; }

        public DbSet<BaseDeDonnéesLivres.Models.LivreDesire> LivreDesire { get; set; }

       // public DbSet<BaseDeDonnéesLivres.Models.RegisterModel> User { get; set; }

    }
}
