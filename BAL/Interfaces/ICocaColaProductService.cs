using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interfaces
{
    public interface ICocaColaProductService
    {
        Task<List<CocaColaProduct>> ProductListAsync();
    }
}
