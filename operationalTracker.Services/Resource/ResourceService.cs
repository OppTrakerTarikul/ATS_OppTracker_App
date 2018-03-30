using operationalTracker.Entities.Models;
using operationalTracker.Repository;
using System;
using System.Collections.Generic;

namespace operationalTracker.Services
{
    public interface IResourceService
    {
        IEnumerable<Resource> getAllResources();
        void addResource(Resource resource);
    }

    public class ResourceService : IResourceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResourceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Resource> getAllResources()
        {
            return _unitOfWork.Resource.GetAllResources();
        }

        public void addResource(Resource resource)
        {
            _unitOfWork.Resource.Add(resource);
            _unitOfWork.SaveChanges();
        }
    }
}
