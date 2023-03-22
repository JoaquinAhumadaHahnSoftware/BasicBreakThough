using CleanMaterial.Application;
using CleanMaterial.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMaterial.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private readonly IMaterialService _service;

        public MaterialsController(IMaterialService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Material>> Get()
        {   
            var materialFromService = _service.GetAllMaterials();
            return Ok(materialFromService);
        }
        [HttpPost]
        public ActionResult<Material> PostMaterial(Material material)
        {
            var Material = _service.CreateMaterial(material);
            return Ok(Material);
        }

    }
}
