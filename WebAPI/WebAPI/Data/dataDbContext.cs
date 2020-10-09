using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI.Data
{
    public class dataDbContext: DbContext
    {
        public dataDbContext(DbContextOptions<dataDbContext> options) :
            base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
    }
}
