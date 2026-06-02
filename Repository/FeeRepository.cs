using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FeeRepository : IFeeRepository<Fee>
    {
        private readonly SchoolManagementContext _context;

        public FeeRepository(SchoolManagementContext context)
        {
            _context = context;
        }

        public IEnumerable<Fee> GetAll()
        {
            return _context.Fees.ToList();
        }

        public Fee GetById(int id)
        {
            return _context.Fees.Find(id);
        }

        public void Add(Fee entity)
        {
            _context.Fees.Add(entity);
        }

        public void Update(Fee entity)
        {
            _context.Fees.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Fees.Find(id);
            if (entity != null)
            {
                _context.Fees.Remove(entity);
            }
        }

    }
}
