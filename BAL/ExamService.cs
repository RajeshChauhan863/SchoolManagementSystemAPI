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
    public class ExamService : IExamService
    {
        private readonly IUnitofWork _unitOfWork;

        public ExamService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Exam GetExamById(int id)
        {
            return _unitOfWork.ExamRepository.GetById(id);
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


        public void AddExam(Exam model)
        {
            _unitOfWork.ExamRepository.Add(model);
            _unitOfWork.SaveChanges();
        }

        public void UpdateExam(Exam model)
        {
            _unitOfWork.ExamRepository.Update(model);
            _unitOfWork.SaveChanges();
        }

        public void DeleteExam(int id)
        {
            _unitOfWork.ExamRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<Exam> GetAllExams()
        {
            return _unitOfWork.ExamRepository.GetAll();
        }

    }
}
