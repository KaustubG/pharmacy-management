using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext (DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WebApi.Models.Users> Users { get; set; }
        public DbSet<WebApi.Models.DrugModel> Drugs { get; set; }
        public  DbSet<WebApi.Models.CartDrugs> Carts { get; set; }
    }
}
