using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capstone._1.Models;

namespace Capstone._1.Data
{
    public class Capstone_1Context : DbContext
    {
        public Capstone_1Context (DbContextOptions<Capstone_1Context> options)
            : base(options)
        {
        }

        public DbSet<Capstone._1.Models.Employee> Employee { get; set; } = default!;
    }
}
