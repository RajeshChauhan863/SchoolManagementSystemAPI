using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ExamRepository : IExamRepository<Exam>
    {
        private readonly SchoolManagementContext _context;

        public ExamRepository(SchoolManagementContext context)
        {
            _context = context;
        }

        public IEnumerable<Exam> GetAll()
        {
            return _context.Exams.ToList();
        }

        public Exam GetById(int id)
        {
            return _context.Exams.Find(id);
        }

        public void Add(Exam entity)
        {
            _context.Exams.Add(entity);
        }

        public void Update(Exam entity)
        {
            _context.Exams.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Exams.Find(id);
            if (entity != null)
            {
                _context.Exams.Remove(entity);
            }
        }
    }
}

