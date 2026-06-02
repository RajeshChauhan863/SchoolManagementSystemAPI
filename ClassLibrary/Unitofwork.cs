
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitofWork
{
    public class Unitofwork : IUnitofWork
    {
        private readonly SchoolManagementContext _context;
        private IExamRepository<Exam> _examRepository;
        private IFeeRepository<Fee> _feeRepository;
        private IStudentRepository<Student> _studentRepository;
        private IAttandanceRepository<Attandance> _attandanceRepository;
        private ITeacherRepository<Teacher> _teacherRepository;
        
        public Unitofwork(SchoolManagementContext context)
        {
            _context = context;
        }

        public IExamRepository<Exam> ExamRepository
        {
            get
            {
                return _examRepository ??= new ExamRepository(_context);
            }
        }


        public IFeeRepository<Fee> FeeRepository
        {
            get
            {
                return _feeRepository ??= new FeeRepository(_context);
            }
        }

        public IStudentRepository<Student> StudentRepository
        {
            get
            {
                return _studentRepository ??= new StudentRepository(_context); 
            }
        }

        public IAttandanceRepository<Attandance> AttandanceRepository
        {
            get
            {
                return _attandanceRepository ??= new AttandanceRepository(_context);
            }
        }

        public ITeacherRepository<Teacher> TeacherRepository
        {
            get
            {
                return _teacherRepository ??= new TeacherRepository(_context);
            }
        }

        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
