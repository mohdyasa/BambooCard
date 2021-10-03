using BambooCard.Common.OrderViewModel;
using BambooCard.Repository.Models;
using BambooCard.Services.Seeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamboo.UnitTests.Helpers
{
    public class Assembler
    {
        public static List<OrderViewModel> orders = new List<OrderViewModel>();
        public static ProductDto product = new ProductDto();
        public static AccountDto accounts = new AccountDto();

        public static void PopulateOrders()
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                orders.Add(new OrderViewModel
                {
                    AccountId = random.Next(1,1000),
                    Products = new List<BambooCard.Common.ProductViewModel.ProductViewModel>
                {
                    new BambooCard.Common.ProductViewModel.ProductViewModel
                    {
                        ProductId = random.Next(1, 1000),
                        Quantity = random.Next(1, 50),
                        Value = random.Next(1000, 50000)
                    }
                }
                });
            }
        }
        public static void AssembleAccounts()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                accounts.accounts.Add(new Account
                {
                    Balance = random.Next(100, 10000),
                    Id = random.Next(1, 200),
                    Currency = "USD",
                    IsActive = true
                });
            }
        }
        public static void PopulateProducts()
        {
            Random random = new Random();
            //PopulateData data = new PopulateData(null);
        }
        
    }
}
