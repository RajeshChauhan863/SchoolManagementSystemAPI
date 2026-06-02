
using DAL.Models;
using Repository;

namespace UnitofWork
{
    public interface IUnitofWork : IDisposable
    {
        IExamRepository<Exam> ExamRepository { get; }
        IFeeRepository<Fee> FeeRepository { get; }
        IStudentRepository<Student> StudentRepository { get; }
        IAttandanceRepository<Attandance> AttandanceRepository { get; }
        ITeacherRepository<Teacher> TeacherRepository { get; }
       

        void SaveChanges();
    }
}
