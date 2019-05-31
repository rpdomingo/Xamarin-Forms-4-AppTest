using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class CocaColaContext : DbContext
    {
        public CocaColaContext(DbContextOptions<CocaColaContext> options) : base(options)
        {
        }

        public virtual DbSet<CocaColaProduct> CocaColaProducts { get; set; }
    }
}
