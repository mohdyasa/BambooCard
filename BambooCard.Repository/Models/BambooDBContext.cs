using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Repository.Models
{
    public class BambooDBContext: DbContext
    {
        public DbSet<Brand> Brands { get; set; }
    }
}
