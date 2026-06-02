using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AttandanceRepository : IAttandanceRepository<Attandance>
    {
        private readonly SchoolManagementContext _context;

        public AttandanceRepository(SchoolManagementContext context)
        {
            _context = context;
        }

        public IEnumerable<Attandance> GetAll()
        {
            return _context.Attandances.ToList();
        }

        public Attandance GetById(int id)
        {
            return _context.Attandances.Find(id);
        }

        public void Add(Attandance entity)
        {
            _context.Attandances.Add(entity);
        }

        public void Update(Attandance entity)
        {
            _context.Attandances.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Attandances.Find(id);
            if (entity != null)
            {
                _context.Attandances.Remove(entity);
            }
        }
    }
}
