
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operationalTracker.Entities.Models;
using operationalTracker.Repository;
using operationalTracker.Repository.Interfaces;

namespace operationalTracker.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly TEST_DBContext _context;

        IResourceRepository _resource;
        ISowRepository _sow;

        public UnitOfWork(TEST_DBContext context)
        {
            _context = context;
        }

        public IResourceRepository Resource
        {
            get
            {
                if (_resource == null)
                    _resource = new ResourceRepository(_context);
                return _resource;
            }
        }

        public ISowRepository Sow
        {
            get
            {
                if (_sow == null)
                    _sow = new SowRepository(_context);
                return _sow;
            }
        }






        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
