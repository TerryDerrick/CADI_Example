using CADI_Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CADI_Example.Persistance
{
    public interface ISystemDbContext
    {
        /// <summary>
        ///  Gets or Sets the <see cref="TestData"/> entries.
        /// </summary>
        DbSet<TestData> TestData { get; set; }
    }
}
