using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface ICocaColaProductRepository : IDisposable
    {
        Task<List<CocaColaProduct>> ProductListAsync();
    }
}
