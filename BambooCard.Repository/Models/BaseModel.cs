using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Repository.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn => DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
