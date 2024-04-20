using MVC_CGPA.Enum;
using MVC_CGPA.Repository.Interface;
using MVC_CGPA.ViewModel;

namespace MVC_CGPA.Repository.Implementation
{
    public class Cgpa : ICgpa
    {
        public decimal CalculateCgpa(List<CgpaDetailsVM> cgpaDetails)
        {
            var cgpa =  CheckGrade(cgpaDetails);
            return cgpa;
        }

        // define the course grade
        public decimal CheckGrade(List<CgpaDetailsVM> details)
        {
            int totalCourseUnit = 0;
            int totalQualityPoint = 0;
            decimal cgpa = 0;
            
            foreach (var detail in details)
            {

                if (detail.CourseGrade == Grade.A.ToString())
                {
                    totalCourseUnit += detail.CourseUnit;
                    totalQualityPoint += (int)Grade.A * detail.CourseUnit;                  
                }                     
            
                else if (detail.CourseGrade == Grade.B.ToString())
                {
                    totalCourseUnit += detail.CourseUnit;
                    totalQualityPoint += (int)Grade.B * detail.CourseUnit;                   
                }           
             
                else if (detail.CourseGrade == Grade.C.ToString())
                {
                    totalCourseUnit += detail.CourseUnit;
                    totalQualityPoint += (int)Grade.C * detail.CourseUnit;                    
                }           
            
                else if (detail.CourseGrade == Grade.D.ToString())
                {
                    totalCourseUnit += detail.CourseUnit;
                    totalQualityPoint += (int)Grade.D * detail.CourseUnit;                    
                }           
            
                else if (detail.CourseGrade == Grade.E.ToString())
                {
                    totalCourseUnit += detail.CourseUnit;
                    totalQualityPoint += (int)Grade.E * detail.CourseUnit;                  
                }           
            
                else
                {
                    totalCourseUnit += detail.CourseUnit;
                    totalQualityPoint += (int)Grade.F * detail.CourseUnit;
                    
                }
            }

            if (totalCourseUnit > 0)
            {
                cgpa = (decimal)totalQualityPoint / totalCourseUnit;
                cgpa = Math.Round(cgpa, 2);
                return cgpa;
            }
            return cgpa;
        }
        //A, C, B => 5, 3, 4 grade point
        //course unt => 3, 2, 3
        //total Qp / total gp => 5*3 + 3*2 + 4*3 / 5+3+4
















       
    }
}
