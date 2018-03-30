using System.Collections.Generic;
using operationalTracker.Entities.Models;

namespace operationalTracker.Repository.Interfaces
{
    public interface ISowRepository : IRepository<Sow>
    {
        void AddSow(Sow sow);
        IEnumerable<Sow> GetAllSows();
    }
}