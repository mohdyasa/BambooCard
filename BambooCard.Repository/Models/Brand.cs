using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace BambooCard.Repository.Models
{
    public class Brand : BaseModel
    {
        public Brand()
        {
        }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public object Disclaimer { get; set; }
        public string RedemptionInstructions { get; set; }
        public object Terms { get; set; }
        public string LogoUrl { get; set; }
        public DateTime ModifiedDate { get; set; }
        public List<Product> Products { get; set; }
    }
    public record ProductDto
    {
        public List<Brand> brands { get; set; }
    }
}
