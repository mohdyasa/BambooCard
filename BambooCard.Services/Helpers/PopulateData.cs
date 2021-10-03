using BambooCard.Common.OrderViewModel;
using BambooCard.Repository.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BambooCard.Services.Seeders
{
    public class PopulateData
    {
        public static ProductDto product;
        public static List<OrderViewModel> orders;
        public static AccountDto accounts;
        private readonly IConfiguration configuration;

        public PopulateData(IConfiguration configuration)
        {
            this.configuration = configuration;
            PopulateProductData();
            PopulateAccounts();
        }
        private async void PopulateProductData()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", configuration.GetSection("AuthKey").Value);
                var response = await client.GetAsync(new Uri(configuration.GetSection("CatalogURL").Value));
                string content = await response.Content.ReadAsStringAsync();
                product = JsonConvert.DeserializeObject<ProductDto>(content);
            }
        }
        private async void PopulateAccounts()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", configuration.GetSection("AuthKey").Value);
                var response = await client.GetAsync(new Uri(configuration.GetSection("AccountSvc").Value));
                string content = await response.Content.ReadAsStringAsync();
                accounts = JsonConvert.DeserializeObject<AccountDto>(content);
            }
        }
    }
}
