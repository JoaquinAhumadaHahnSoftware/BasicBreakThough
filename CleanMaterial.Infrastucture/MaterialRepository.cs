using CleanMaterial.Application;
using CleanMaterial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMaterial.Infrastructure
{
    internal class MaterialRepository : IMaterialRepository
    {
        public static List<Material> materials = new List<Material>()
        {
            new Material{Id = 1, Name = "Iron", Cost = 120},
            new Material{Id = 1, Name = "Steel", Cost = 200}
        };
        public List<Material> GetAllMaterials()
        {
            return materials;
        }
    }
}
