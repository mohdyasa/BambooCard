using Bamboo.UnitTests.Helpers;
using BambooCard.Services.Account;
using BambooCard.Services.Seeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bamboo.UnitTests
{
    public class AccountTests
    {
        [Fact]
        public async void GetAccount()
        {
            var accountService = new AccountService();
            Assembler.AssembleAccounts();
            PopulateData.accounts = Assembler.accounts;
            var result = await accountService.GetAccounts();
            Assert.True(result.accounts.Count > 0);
            
        }
    }
}
