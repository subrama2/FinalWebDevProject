using FinalWebDevProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWebDevProject.Info
{
    public class CoursesDbContext : DbContext
    {

        public DbSet<CoursesModel> CourseData { get; set; }

        public CoursesDbContext()
        {
        }

        public CoursesDbContext(DbContextOptions<CoursesDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NAG6CHANDRVAR01; initial catalog=CoursesDb;integrated security=true");
        }
    }
}
