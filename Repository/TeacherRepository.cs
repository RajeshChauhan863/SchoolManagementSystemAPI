using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TeacherRepository : ITeacherRepository<Teacher>
    {
        private readonly SchoolManagementContext _context;

        public TeacherRepository(SchoolManagementContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetById(int id)
        {
            return _context.Teachers.Find(id);
        }

        public void Add(Teacher entity)
        {
            _context.Teachers.Add(entity);
        }

        public void Update(Teacher entity)
        {
            _context.Teachers.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Teachers.Find(id);
            if (entity != null)
            {
                _context.Teachers.Remove(entity);
            }
        }
    }
}

