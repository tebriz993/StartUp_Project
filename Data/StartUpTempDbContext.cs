using StartUpTemp.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace StartUpTemp.Data
{
    
        public class StartUpTempDbContext : DbContext
        {
            public StartUpTempDbContext(DbContextOptions<StartUpTempDbContext> options) : base(options)
            {

            }

            //Models
            //public DbSet<Home> Home { get; set; }
            public DbSet<About> About { get; set; }
            public DbSet<Services> Services { get; set; }
            public DbSet<BlogDetail> BlogDetail { get; set; }

            public DbSet<BlogGrid> BlogGrid { get; set; }
            public DbSet<PageTeam> PageTeam { get; set; }
            public DbSet<PagePrice> PagePrice { get; set; }
            public DbSet<PageFeature> PageFeature { get; set; }
            public DbSet<PageTestimonial> PageTestimonial { get; set; }
            public DbSet<Home> Home { get; set; }

            


    }
    
}
