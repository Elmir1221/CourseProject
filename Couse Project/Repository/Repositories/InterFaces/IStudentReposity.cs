using Course_project.Models;
using Service.Services.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Repositories.InterFaces
{
    public interface IStudentReposity : IBaseRepositories<Student>
    {

        List<Student> GetByAge(int age);
        List<Student> GetStudentByGroupId(int? id);
        List<Student> GetAllStudents(string data);
    }
}

   
    
