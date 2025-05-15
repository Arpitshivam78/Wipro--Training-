using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Office_data.Models;

namespace Office_data.Data
{
    public class Office_dataContext : DbContext
    {
        public Office_dataContext (DbContextOptions<Office_dataContext> options)
            : base(options)
        {
        }

        public DbSet<Office_data.Models.Employee> Employee { get; set; } = default!;
    }
}
