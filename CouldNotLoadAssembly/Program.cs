using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;
using System;

namespace CouldNotLoadAssembly
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql("fake connection string", onConfiguringNpgsql);
        }

        static private void onConfiguringNpgsql(NpgsqlDbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNetTopologySuite();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(new MyDbContext());
        }
    }
}