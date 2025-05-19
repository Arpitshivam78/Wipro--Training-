using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapplication1.Models;

namespace webapplication1.Data
{
    public class webapplication1Context : DbContext
    {
        public webapplication1Context (DbContextOptions<webapplication1Context> options)
            : base(options)
        {
        }

        public DbSet<webapplication1.Models.Student> Student { get; set; } = default!;
    }
}
