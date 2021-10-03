using BambooCard.Services.Catalog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BambooCard.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService service;

        public CatalogController(ICatalogService service )
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetCatalog()
        {
            return Ok(await service.GetBrands());
        }
    }
}
