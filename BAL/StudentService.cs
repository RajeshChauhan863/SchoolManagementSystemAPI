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
    public class StudentService : IStudentService
    {
        private readonly IUnitofWork _unitOfWork;

        public StudentService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Student GetStudentById(int id)
        {
            return _unitOfWork.StudentRepository.GetById(id);
        }



        public string UserLogin(string username, string password)
        {
            var userId = "rajeshchauhan8893@gmail.com";
            var userEmail = "rajeshchauhan8893@gmail.com";
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("YourSecretKey"); // Replace with your secret key
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()), // Replace with your user ID
            new Claim(JwtRegisteredClaimNames.Email, userEmail), // Replace with user email
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        }),
                Expires = DateTime.UtcNow.AddMinutes(30), // Token expiration time
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);




        }


        public void AddStudent(Student model)
        {
            _unitOfWork.StudentRepository.Add(model);
            _unitOfWork.SaveChanges();
        }

        public void UpdateStudent(Student product)
        {
            _unitOfWork.StudentRepository.Update(product);
            _unitOfWork.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            _unitOfWork.StudentRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _unitOfWork.StudentRepository.GetAll();
        }

    }
}
