using BambooCard.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Services.Account
{
    public interface IAccountService
    {
        Task<AccountDto> GetAccounts();
    }
}
