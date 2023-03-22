using CleanMaterial.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMaterial.Infrastructure
{
    public class MaterialDbContext : DbContext
    {
        public MaterialDbContext(DbContextOptions<MaterialDbContext>options)
            : base(options)
        {
            
        }

        public DbSet<Material> Materials { get; set; }
    }
}
