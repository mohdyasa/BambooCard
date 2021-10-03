using BambooCard.Common.Exceptions;
using BambooCard.Common.OrderViewModel;
using BambooCard.Services.Seeders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BambooCard.Services.Order
{
    public class OrderService : IOrderService
    {
        private readonly ILogger<OrderService> logger;

        public OrderService(ILogger<OrderService> logger)
        {
            this.logger = logger;
        }
        public Guid CreateOrder(OrderViewModel model)
        {
            if(PopulateData.orders.Any(x=>x.RequestId == model.RequestId))
            {
                throw new DuplicateKeyException($"Order Already Exists with requestId: {model.RequestId} ");
            }
            PopulateData.orders.Add(model);
            return model.RequestId;
        }

        public async Task<IEnumerable<OrderViewModel>> GetOrders(int AccountId)
        {
            return PopulateData.orders?.Where(x=>x.AccountId ==  AccountId).ToList();
        }
    }
}
