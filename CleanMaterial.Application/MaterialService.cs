using CleanMaterial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMaterial.Application
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _materialRepository;

        //Constructor Dependency Injection
        public MaterialService(IMaterialRepository  materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public Material CreateMaterial(Material material)
        {
            _materialRepository.CreateMaterial(material);
            return material;
        }

        public List<Material> GetAllMaterials()
        {
            var materials = _materialRepository.GetAllMaterials();

            return materials;
        }
    }
}
