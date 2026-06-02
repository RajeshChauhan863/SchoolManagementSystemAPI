using DAL.Models;
namespace BAL
{
    public interface IExamService
    {
        IEnumerable<Exam> GetAllExams();
        Exam GetExamById(int id);
        void AddExam(Exam model);
        void UpdateExam(Exam model);
        void DeleteExam(int id);
        
        string UserLogin(string userName, string password);

    }
}
