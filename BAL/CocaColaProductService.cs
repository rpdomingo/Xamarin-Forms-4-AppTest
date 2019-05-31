using BAL.Interfaces;
using DAL.Repositories.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CocaColaProductService: ICocaColaProductService
    {
        private readonly ICocaColaProductRepository _cocaColaProductRepository;

        public CocaColaProductService(ICocaColaProductRepository cocaColaProductRepository)
        {
            _cocaColaProductRepository = cocaColaProductRepository;
        }

        public Task<List<CocaColaProduct>> ProductListAsync()
        {
            return _cocaColaProductRepository.ProductListAsync();
        }
    }
}
