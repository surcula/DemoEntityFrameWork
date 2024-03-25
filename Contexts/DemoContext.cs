using DemoEntityFrameWork.Configurations;
using DemoEntityFrameWork.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFrameWork.Contexts
{
    public class DemoContext : DbContext
    {
        public DbSet<Person> Persons {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-HSV5O301;Initial Catalog=DemoEntity;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }
    }
}
