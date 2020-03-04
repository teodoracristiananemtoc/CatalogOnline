using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proiect.Models;

namespace proiect.Data
{
    public class proiectContext : DbContext
    {
        public proiectContext (DbContextOptions<proiectContext> options)
            : base(options)
        {
        }

        public DbSet<proiect.Models.Curs> Curs { get; set; }

        public DbSet<proiect.Models.Inrolare> Inrolare { get; set; }

        public DbSet<proiect.Models.Student> Student { get; set; }

       
    }
}
