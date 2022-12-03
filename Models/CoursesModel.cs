using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWebDevProject.Models
{
    public class CoursesModel
    {
        [Key]
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public string ProfessorName { get; set; }
        public int Day { get; set; }
    }
}
