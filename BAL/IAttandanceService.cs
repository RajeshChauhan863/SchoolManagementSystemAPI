using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IAttandanceService
    {
        IEnumerable<Attandance> GetAllAttandances();
        Attandance GetAttandanceById(int id);
        void AddAttandance(Attandance model);
        void UpdateAttandance(Attandance model);
        void DeleteAttandance(int id);

    }
}
