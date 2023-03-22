using CleanMaterial.Application;
using CleanMaterial.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMaterial.API.Controllers
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
            var materialsFromService = _service.GetAllMaterials();
            return Ok(materialsFromService);
        }
    }
}
