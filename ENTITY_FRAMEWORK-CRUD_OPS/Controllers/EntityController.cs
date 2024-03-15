using ENTITY_FRAMEWORK_CRUD_OPS.Model;
using ENTITY_FRAMEWORK_CRUD_OPS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENTITY_FRAMEWORK_CRUD_OPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        public readonly IEntityService _entityService;
        public EntityController(IEntityService entityService)
        {
            _entityService = entityService;
        }

        [HttpGet]
        public IActionResult GetAl() 
        {
            return Ok(_entityService.GetAll());
        }
        [HttpGet("Id")]
        public IActionResult GetById(int id) 
        {
            return Ok(_entityService.GetById(id));
        }
        [HttpPost]
        public IActionResult AddEntity(Entity entity)
        {
            _entityService.AddEntity(entity);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            _entityService.DeleteEntity(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateEntity(Entity entity) 
        {
            _entityService.UpdateEntity(entity);
            return Ok();
        }
    }
}
