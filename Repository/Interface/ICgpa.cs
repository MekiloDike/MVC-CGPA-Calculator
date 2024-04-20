using MVC_CGPA.Models;
using MVC_CGPA.ViewModel;

namespace MVC_CGPA.Repository.Interface
{
    public interface ICgpa
    {
        /*public bool AddCgpa(Cgpa cgpa);
        public bool CalculateCgpa();*/
        public decimal CalculateCgpa(List<CgpaDetailsVM> cgpaDetails);
    }
}
