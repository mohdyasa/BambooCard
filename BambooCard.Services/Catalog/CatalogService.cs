using BambooCard.Services.Seeders;
using BambooCard.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BambooCard.Services.Catalog
{
    public class CatalogService : ICatalogService
    {
        private readonly ILogger<CatalogService> logger;

        public CatalogService(ILogger<CatalogService> logger)
        {
            this.logger = logger;
        }
        public async Task<ProductDto> GetBrands()
        {
            return PopulateData.product;
        }
    }
}
