using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RedPlus.Website.Models;

namespace RedPlus.Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RedPlus.Website.Models.Blog> Blog { get; set; }
        public DbSet<RedPlus.Website.Models.Post> Post { get; set; }
    }
}
