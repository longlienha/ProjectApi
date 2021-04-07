using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace project_v2.Models
{
    public class WebContext :DbContext
    {
        public WebContext(DbContextOptions<WebContext> opt):base(opt)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores{get;set;}
        // public string ConnectStrring = @"Data Source=DESKTOP-3IAVUPL;Initial Catalog=quanlymathang;User ID=sa;Password=123456";
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                    builder.AddConsole()
                           .AddFilter(DbLoggerCategory.Database.Command.Name,
                                    LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(ConnectStrring);
        //     optionsBuilder.UseLoggerFactory(GetLoggerFactory());
        // }

        
    }
}
