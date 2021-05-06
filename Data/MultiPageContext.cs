using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class MultiPageContext : DbContext
    {
        public MultiPageContext(DbContextOptions<MultiPageContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProject.Models.Lifters> Lifters { get; set; }
    }
}
