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

        public DbSet<CaoMinhQuang108.Models.UniversityCMQ108> UniversityCMQ108S { get; set; }

        public DbSet<CaoMinhQuang108.Models.CMQ0108> CMQ0108 { get; set; }

        public DbSet<CaoMinhQuang108.Models.StringProcessCMQ108> StringProcessCMQ108 { get; set; }
    }
