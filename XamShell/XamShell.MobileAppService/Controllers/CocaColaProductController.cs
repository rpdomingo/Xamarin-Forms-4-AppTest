using BAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace XamShell.MobileAppService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocaColaProductController : ControllerBase
    {
        private readonly ICocaColaProductService _cocaColaProductService;

        public CocaColaProductController(ICocaColaProductService cocaColaProductService)
        {
            _cocaColaProductService = cocaColaProductService;
        }

        [HttpGet]
        public async Task<IActionResult> ListOfCocaColaProduct()
        {
            try
            {
                return Ok(await _cocaColaProductService.ProductListAsync());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}