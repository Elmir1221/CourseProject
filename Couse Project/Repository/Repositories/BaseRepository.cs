﻿using Course_project.Common;
using Repository.Data;
using Service.Services.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepositories<T> where T : BaseEntity
    {
        public void Create(T entity)
        {
            AppDbContext<T>.datas.Add(entity);
        }

        public void Delete(T entity)
        {
            AppDbContext<T>.datas.Remove(entity);
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllById()
        {
            return AppDbContext<T>.datas.ToList();
        }

        public List<T> GetAllWithExpression(Func<T, bool> predicate)
        {
            return AppDbContext<T>.datas.Where(predicate).ToList();
        }

      
    }
}
