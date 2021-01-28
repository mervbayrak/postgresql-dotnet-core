using Microsoft.EntityFrameworkCore;
using PostgreSql.DAL.Concrete.EntityFramework.Mappings;
using PostgreSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.DAL.Concrete.EntityFramework.Context
{
    public class MyDBContext : DbContext
    {
        static String DbAddr = "localhost", DbUserId = "postgres", DbPass = "123456";
        static String DbConnStr = String.Format("Server={0};Port=5432;User Id={1};Password={2};Database=MyDb;", DbAddr, DbUserId, DbPass);


        DbSet<User> Users { get; set; }
        public MyDBContext() { }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connectionString: DbConnStr);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
