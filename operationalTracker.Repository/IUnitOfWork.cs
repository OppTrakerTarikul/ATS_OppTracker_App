// ====================================================
// Design: Ayan Roy
// ====================================================

using operationalTracker.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operationalTracker.Repository
{
    public interface IUnitOfWork
    {
        IResourceRepository Resource { get; }
        ISowRepository Sow { get; }
        int SaveChanges();
    }
}
