using CleanMaterial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMaterial.Application
{

    //This is a use case
    public interface IMaterialService
    {
        List<Material> GetAllMaterials();
        Material CreateMaterial(Material material);
    }
}
