using CodeGenerator.Core;
using CodeGenerator.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CodeGenerator
{
    public class MyDBContext: DbContext
    {
        private string connectionString = @"server=localhost;uid=root;pwd=networks;database=testingdatabase;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            base.OnConfiguring(optionsBuilder);
        }

        public override int SaveChanges()
        {
            for (var i= 0; i < ChangeTracker.Entries().Count(); i++)
            {
                var entry = ChangeTracker.Entries().Skip(i).Take(1).First();
                if (entry.State == EntityState.Added)
                {
                    foreach (var prop in entry.Entity.GetType().GetProperties())
                    {
                        var tAttributes = prop.GetCustomAttributes(typeof(SeriesGenerateAttribute), true);
                        foreach (var ta in tAttributes)
                        {
                            var prefix = ((SeriesGenerateAttribute)ta).GetPrefix();
                            prop.SetValue(entry.Entity, GenerateNewSeries(prefix), null);
                        }
                    }
                }
            }

            return base.SaveChanges();
        }

        public int SaveChangeWithoutCodeGenerator()
        {
            return base.SaveChanges();
        }

        public DbSet<User> User { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<ConfigSeries> ConfigSeries { get; set; }



        #region UtilityFunction
        public string GenerateNewSeries(string seriesType)
        {
            var currentDate = DateTime.Now;
            var tEntity = this.ConfigSeries
                                    .Where(x => x.SeriesType == seriesType)
                                    .FirstOrDefault();


            if (tEntity == null)
            {
                tEntity = new ConfigSeries()
                {
                    MaxNumber = 1,
                    SeriesType = seriesType,
                };
                this.ConfigSeries.Add(tEntity);
            }
            else
            {
                tEntity.MaxNumber++;
            }


            return String.Concat(tEntity.SeriesType, '_', tEntity.MaxNumber.ToString("000000"));
        }
        #endregion
    }
}
