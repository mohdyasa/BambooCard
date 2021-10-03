using BambooCard.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Services.Catalog
{
    public interface ICatalogService
    {
        Task <ProductDto> GetBrands();
    }
}
