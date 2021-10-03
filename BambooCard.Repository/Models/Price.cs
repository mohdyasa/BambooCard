using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Repository.Models
{
    public class Price
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public string CurrencyCode { get; set; }
    }
}
