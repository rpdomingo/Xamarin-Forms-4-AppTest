using DAL.Context;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CocaColaProductRepository : ICocaColaProductRepository
    {
        bool disposed = false;
        private readonly CocaColaContext _cocaColaContext;

        public CocaColaProductRepository(CocaColaContext cocaColaContext)
        {
            _cocaColaContext = cocaColaContext;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                _cocaColaContext.Dispose();
            }

            disposed = true;
        }

        public async Task<List<CocaColaProduct>> ProductListAsync()
        {
            return await _cocaColaContext.Set<CocaColaProduct>().ToListAsync();
        }
    }
}
