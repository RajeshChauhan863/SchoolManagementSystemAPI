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
    public class AttandanceService : IAttandanceService
    {
        private readonly IUnitofWork _unitOfWork;

        public AttandanceService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Attandance GetAttandanceById(int id)
        {
            return _unitOfWork.AttandanceRepository.GetById(id);
        }




        public void AddAttandance(Attandance model)
        {
            _unitOfWork.AttandanceRepository.Add(model);
            _unitOfWork.SaveChanges();
        }

        public void UpdateAttandance(Attandance model)
        {
            _unitOfWork.AttandanceRepository.Update(model);
            _unitOfWork.SaveChanges();
        }

        public void DeleteAttandance(int id)
        {
            _unitOfWork.AttandanceRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<Attandance> GetAllAttandances()
        {
            return _unitOfWork.AttandanceRepository.GetAll();
        }

    }
}
