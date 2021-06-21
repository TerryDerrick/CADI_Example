using CADI_Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace CADI_Example.Persistance
{
    public class SystemDbContext : DbContext, ISystemDbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options)
             : base(options)
        {
        }

        /// <inheritdoc/>
        public virtual DbSet<TestData> TestData { get; set; }
    }
}
