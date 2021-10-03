using Bamboo.UnitTests.Helpers;
using BambooCard.Services.Catalog;
using BambooCard.Services.Seeders;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bamboo.UnitTests
{
    public class CatalogTests
    {

        [Fact]
        public async void GetOrdersByAccount()
        {
            var orderService = new CatalogService(CreateLogger<CatalogService>());
            //PopulateData.product = Assembler;
            //Assert.NotNull(orders);
        }
        private ILogger<T> CreateLogger<T>()
        {
            var mock = new Mock<ILogger<T>>();
            return mock.Object;
        }
    }
}
