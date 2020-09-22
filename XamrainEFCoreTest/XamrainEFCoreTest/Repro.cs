using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace XamrainEFCoreTest
{
    public static class Repro
    {
        public static void Test()
        {
            using (var cntxt = new MyDbContext())
            {
                cntxt.Set<SubModel>(); //<- throws here
            }
        }
    }

    public class MyDbContext : DbContext
    {
        public DbSet<SubModel> SubModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = :memory:");
        }
    }

    public class SubModel : TestModel
    {
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
    }

    public abstract class TestModel
    {
        [Key]
        public int Id { get; set; }
        public string A { get; set; }
    }
}
