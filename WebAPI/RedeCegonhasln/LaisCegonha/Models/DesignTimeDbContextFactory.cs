using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using laiscegonha.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace laiscegonha.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LaisContext>
    {
        public LaisContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<LaisContext>();

            var connectionString = configuration.GetConnectionString("DBredeCegonha");

            builder.UseMySql(connectionString);

            return new LaisContext(builder.Options);
        }
    }
}