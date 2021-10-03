using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Repository.Models
{
    public class Product: BaseModel
    {
        public string Name { get; set; }
        public double MinFaceValue { get; set; }
        public double MaxFaceValue { get; set; }
        public int? Count { get; set; }
        public Price price { get; set; }
    }
   
}
