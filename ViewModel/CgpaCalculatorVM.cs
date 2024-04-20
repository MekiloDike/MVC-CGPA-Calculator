using MVC_CGPA.Models;

namespace MVC_CGPA.ViewModel
{
    /*public class CgpaVM
    {
        public List<CgpaDetailsVM>? CgpaDetailsVMs { get; set; }
    }*/
    public class CgpaDetailsVM
    {
        public string CourseName { get; set; }
        public string CourseGrade { get; set; }
        public int CourseUnit { get; set; }
        public int GradePoint { get; set; }

    }

}
