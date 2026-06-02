using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface ITimeTableService
    {
        IEnumerable<TimeTable> GetAllTimeTables();
        TimeTable GetTimeTableById(int id);
        void AddTimeTable(TimeTable model);
        void UpdateTimeTable(TimeTable model);
        void DeleteTimeTable(int id);
    }
}
