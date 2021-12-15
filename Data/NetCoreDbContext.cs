using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaoMinhQuang108.Models;

    public class NetCoreDbContext : DbContext
    {
        public NetCoreDbContext (DbContextOptions<NetCoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<CaoMinhQuang108.Models.University> University { get; set; }
    }
