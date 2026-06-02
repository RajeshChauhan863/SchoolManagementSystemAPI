using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IfeeService
    {
        IEnumerable<Fee> GetAllFees();
        Fee GetFeeById(int id);
        void AddFee(Fee product);
        void UpdateFee(Fee product);
        void DeleteFee(int id);

    }
}
