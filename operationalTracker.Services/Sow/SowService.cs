using operationalTracker.Entities.Models;
using operationalTracker.Repository;
using System;
using System.Collections.Generic;

namespace operationalTracker.Services
{
    public interface ISowService
    {
        IEnumerable<Sow> getAllSows();
        void addResource(Sow resource);
    }

    public class SowService : ISowService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SowService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Sow> getAllSows()
        {
            return _unitOfWork.Sow.GetAllSows();
        }

        public void addResource(Sow sowDetails)
        {
            _unitOfWork.Sow.Add(sowDetails);
            _unitOfWork.SaveChanges();
        }
    }
}
