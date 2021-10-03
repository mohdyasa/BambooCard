using BambooCard.Repository.Models;
using BambooCard.Services.Seeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Services.Account
{
    public class AccountService : IAccountService
    {
        public async Task<AccountDto> GetAccounts()
        {
            return PopulateData.accounts;
        }
    }
}
