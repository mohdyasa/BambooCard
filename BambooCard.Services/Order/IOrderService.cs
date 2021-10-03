using BambooCard.Common.OrderViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Services.Order
{
    public interface IOrderService
    {
        Guid CreateOrder(OrderViewModel model);
        Task<IEnumerable<OrderViewModel>> GetOrders(int AccountId);
    }
}
