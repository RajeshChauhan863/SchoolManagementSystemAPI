using DAL.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UnitofWork;

namespace BAL
{
    public class TeacherService : ITeacherService
    {
        private readonly IUnitofWork _unitOfWork;

        public TeacherService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Teacher GetTeacherById(int id)
        {
            return _unitOfWork.TeacherRepository.GetById(id);
        }




        public void AddTeacher(Teacher model)
        {
            _unitOfWork.TeacherRepository.Add(model);
            _unitOfWork.SaveChanges();
        }

        public void UpdateTeacher(Teacher model)
        {
            _unitOfWork.TeacherRepository.Update(model);
            _unitOfWork.SaveChanges();
        }

        public void DeleteTeacher(int id)
        {
            _unitOfWork.TeacherRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _unitOfWork.TeacherRepository.GetAll();
        }

    }
}
