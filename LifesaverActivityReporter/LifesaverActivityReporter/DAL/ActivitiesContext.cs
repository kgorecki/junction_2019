//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

using LifesaverActivityReporter.Models;

namespace LifesaverActivityReporter.DAL
{
    public class ActivitiesContext : DbContext
    {
        public ActivitiesContext(DbContextOptions<ActivitiesContext> options) : base(options)
        //public ActivitiesContext() : base("ActivitiesContext")
        {
        }

        public DbSet<ActivityType> ActivityTypes { get; set; }

        public DbSet<Activity> Activities { get; set; }
    }
}