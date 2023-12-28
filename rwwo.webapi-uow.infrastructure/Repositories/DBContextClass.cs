using Microsoft.EntityFrameworkCore;
using rwwo.webapi_uow.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rwwo.webapi_uow.infrastructure.Repositories
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
