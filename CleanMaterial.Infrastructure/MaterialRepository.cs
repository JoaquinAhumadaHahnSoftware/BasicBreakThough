using CleanMaterial.Application;
using CleanMaterial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMaterial.Infrastructure
{
    public class MaterialRepository : IMaterialRepository
    {

 
        private readonly MaterialDbContext _materialDbContext;

        public MaterialRepository(MaterialDbContext materialDbContext)
        {
            _materialDbContext = materialDbContext;
        }
        public Material CreateMaterial(Material material)
        {
            _materialDbContext.Materials.Add(material);
            _materialDbContext.SaveChanges();

            return material;
        }

        public List<Material> GetAllMaterials()
        {
           return _materialDbContext.Materials.ToList();
        }
    }
}
