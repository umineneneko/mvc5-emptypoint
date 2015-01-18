using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using web.Models;

namespace web.DAL
{
    public class TVDbContext:DbContext
    {
        public TVDbContext() : base("TVDbContext") { }
        public DbSet<TVSeries> TVSeries { get; set; }
        public DbSet<TVChannel> TVChannels { get; set; }
        public DbSet<ScheduleList> TVSchedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }
    }
}