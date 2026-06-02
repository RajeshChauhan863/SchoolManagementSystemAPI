using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TimeTableRepository : ITimeTableRepostiory<TimeTable>
    {
        private readonly SchoolManagementContext _context;

        public TimeTableRepository(SchoolManagementContext context)
        {
            _context = context;
        }

        public IEnumerable<TimeTable> GetAll()
        {
            return _context.TimeTables.ToList();
        }

        public Teacher GetById(int id)
        {
            return _context.TimeTables.Find(id);
        }

        public void Add(TimeTable entity)
        {
            _context.TimeTables.Add(entity);
        }

        public void Update(TimeTable entity)
        {
            _context.TimeTables.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.TimeTables.Find(id);
            if (entity != null)
            {
                _context.TimeTables.Remove(entity);
            }
        }
    }
}
