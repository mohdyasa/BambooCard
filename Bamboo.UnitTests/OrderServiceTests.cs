using Bamboo.UnitTests.Helpers;
using BambooCard.Services.Order;
using BambooCard.Services.Seeders;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using BambooCard.Common;
using BambooCard.Common.ProductViewModel;
using BambooCard.Common.OrderViewModel;
using BambooCard.Common.Exceptions;

namespace Bamboo.UnitTests
{
    public class OrderServiceTests
    {
        [Fact]
        public async void GetOrdersByAccount()
        {
           var orderService = new OrderService(CreateLogger<OrderService>());
            SetOrder(2);
            Assembler.PopulateOrders();
            PopulateData.orders = Assembler.orders;
           var orders = await orderService.GetOrders(2);
            Assert.NotNull(orders);
        }
        
        [Fact]
        public async void AddDuplicateOrder()
        {
            Assembler.PopulateOrders();
            var existingOrder = Assembler.orders.First();
            try
            {
                var orderService = new OrderService(CreateLogger<OrderService>());
                PopulateData.orders = Assembler.orders;
                ProductViewModel product = new ProductViewModel { ProductId = 232, Quantity = 2, Value = 1223 };
                var orders = orderService.CreateOrder(existingOrder);
            }
            catch (DuplicateKeyException ex)
            {
                Assert.Contains($"Order Already Exists with requestId: {existingOrder.RequestId}", ex.Message);
            }
            catch (Exception ex)
            {
            }
        }
        private ILogger<T> CreateLogger<T>()
        {
            var mock = new Mock<ILogger<T>>();
            return mock.Object;
        }
        private static void SetOrder(int AccountId)
        {
           if(Assembler.orders?.Count > 0 && Assembler.orders.Any(x=>x.AccountId == AccountId))
            {
                return;
            }
            else
            {
                ProductViewModel product = new ProductViewModel { ProductId = 232, Quantity = 2, Value = 1223 };
                var order = new OrderViewModel
                {
                    AccountId = AccountId,
                    Products = new List<ProductViewModel> { product },
                    RequestId = Guid.NewGuid()
                };
                Assembler.orders.Add(order);
            }
        }
    }
}
