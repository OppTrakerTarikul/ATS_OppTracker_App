using operationalTracker.Entities.Models;
using operationalTracker.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace operationalTracker.Repository
{
    public class SowRepository : Repository<Sow>, ISowRepository
    {
        private TEST_DBContext _appContext => (TEST_DBContext)_context;

        public SowRepository(TEST_DBContext context) : base(context) { }

        public IEnumerable<Sow> GetAllSows()
        {
            return _appContext.Sow.ToList();
        }


        public void AddSow(Sow sow)
        {
            _appContext.Sow.Add(sow);
            _appContext.SaveChanges();
        }

    }
}
