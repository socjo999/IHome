using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IHome.Models;

namespace IHome.Models
{
    public class EFCContext : IdentityDbContext
    {
        public static readonly ILoggerFactory factory
        = LoggerFactory.Create(builder => { builder.AddConsole(); });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddXmlFile("appsettings.xml");
            var cs = configurationBuilder.Build();
            optionsBuilder
                .UseLoggerFactory(factory)
                .EnableSensitiveDataLogging()
                .UseSqlServer(cs["ConnectionString"]);
        }
        public DbSet<Buildings> Buildings{ get; set; }
        public DbSet<Zones> Zones { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Devices> Devices { get; set; }
        public DbSet<IHome.Models.Action> Action { get; set; }
        public DbSet<IHome.Models.Condition> Condition { get; set; }
        public DbSet<IHome.Models.Scheduler> Scheduler { get; set; }

    }
}
