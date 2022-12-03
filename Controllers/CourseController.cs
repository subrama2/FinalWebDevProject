using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using FinalWebDevProject.Models;

namespace FinalWebDevProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly IcourseDataAccess _courseDataAccess;

        public CourseController(
            IcourseDataAccess courseDataAccess)
        {
            _courseDataAccess = courseDataAccess;
        }

        [HttpPost]
        [Route("createorder")]

        public async Task<IActionResult> CreateCourse([FromBody] CoursesModel coursesModel)
        {
            _courseDataAccess.SaveCourse(coursesModel);

            return Ok("Success");
        }

        [HttpGet]
        [Route("getall")]

        public async Task<IActionResult?> GetAll()
        {
            try
            {
                return Ok(_courseDataAccess.GetAllCourse());
            }
            catch (Exception ex)
            {
                return null;
            }
         }
    }
}
