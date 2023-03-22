using CleanMaterial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMaterial.Application
{
    public interface IMaterialRepository
    {
        List<Material> GetAllMaterials();
        Material CreateMaterial(Material material);   
    }
}
