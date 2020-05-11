using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShitBookCoreAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Ksiazki> Ksiazki { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
