using Course_project.Models;
using Repository.Data;
using Repository.Repositories;
using Service.Services.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Repository
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public List<Group> GeAllGroupsByName(string name)
        {
            return AppDbContext<Group>.datas.Where(m => m.Name == name).ToList();
        }

        public List<Group> GetAllGroups(int? id)
        {
            return AppDbContext<Group>.datas.ToList();
        }

        public List<Group> GetGroupsByTeacher(string teacher)
        {
            return AppDbContext<Group>.datas.Where(m => m.Teacher == teacher).ToList();
        }

        public List<Group> GetGroupsByRoom(string room)
        {
            return AppDbContext<Group>.datas.Where(m => m.Room == room).ToList();
        }
    }
}
