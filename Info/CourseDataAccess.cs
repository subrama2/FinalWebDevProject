using FinalWebDevProject.Controllers;
using FinalWebDevProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWebDevProject.Info
{
    public class CourseDataAccess : IcourseDataAccess
    {
        public List<CoursesModel> GetAllCourse()
        {
            using (var context = new CoursesDbContext())
            {
                return context.CourseData.ToList();
            }
        }
        public void SaveCourse(CoursesModel courses)
        {
            using (var context = new CoursesDbContext())
            {
                context.Add<CoursesModel>(courses);
                context.SaveChanges();
            }
        }
    }
}
