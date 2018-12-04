using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<ApiProduct>> GetAsync()
        {
            return new[] {new ApiProduct {Id = Guid.NewGuid(), Description = "fake"}};
        }
        [HttpPost]
        public async Task Post([FromBody] ApiProduct product)
        {


        }

        
    }
}
