using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Repository.Models
{
    public class Account: BaseModel
    {
        public string Currency { get; set; }
        public double Balance { get; set; }
        public bool IsActive { get; set; }
    }
    public record AccountDto
    {
        public List<Account> accounts { get; set; }
    }
}
