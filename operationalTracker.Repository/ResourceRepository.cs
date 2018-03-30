using operationalTracker.Entities.Models;
using operationalTracker.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace operationalTracker.Repository
{
    public class ResourceRepository : Repository<Resource>, IResourceRepository
    {

        private TEST_DBContext _appContext => (TEST_DBContext)_context;
        //private readonly TEST_DBContext _ctx;
        //public ResourceRepository(ResourceRepository ctx) : base(context)
        //{
        //    _ctx = ctx;
        //}

        public ResourceRepository(TEST_DBContext context) : base(context)
        { }

        public IEnumerable<Resource> GetAllResources()
        {
            return _appContext.Resource.ToList();
        }

        //public TableResource GetResourceDetails(int id)
        //{
        //    return _ctx.TableResource.FirstOrDefault(x => x.ResourceId == id);
        //}

        public void AddEmployee(Resource resource)
        {
            _appContext.Resource.Add(resource);
            _appContext.SaveChanges();
        }

        //public bool SaveAll()
        //{
        //    return _ctx.SaveChanges() > 0;
        //}

        //private TEST_DBContext _appContext => (TEST_DBContext)_context;
    }
}
