using System.Collections.Generic;
using operationalTracker.Entities.Models;

namespace operationalTracker.Repository.Interfaces
{
    public interface IResourceRepository : IRepository<Resource>
    {
        //void AddEmployee(TableResource resource);
        IEnumerable<Resource> GetAllResources();
        //TableResource GetResourceDetails(int id);
        //bool SaveAll();
    }
}