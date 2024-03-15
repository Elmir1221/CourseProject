﻿using Course_project.Models;
using Repository.Data;
using Repository.Repositories.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentReposity
    {
        public List<Student> GetAllStudents(string data)
        {
           return AppDbContext<Student>.datas.ToList();
        }

        public List<Student> GetByAge(int age)
        {
            return AppDbContext<Student>.datas.Where(m => m.Age == age).ToList();
        }

        public List<Student> GetStudentByGroupId(int? id)
        {
            return AppDbContext<Student>.datas.Where(m => m.Group.Id == id).ToList();
        }

    }
}
