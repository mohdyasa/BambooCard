using System;
using System.Collections.Generic;
namespace BambooCard.Common.OrderViewModel
{
    public class OrderViewModel
    {
        public Guid RequestId { get; set; } = Guid.NewGuid();
        public int AccountId { get; set; }
        public List<ProductViewModel.ProductViewModel> Products { get; set; }
    }
}
