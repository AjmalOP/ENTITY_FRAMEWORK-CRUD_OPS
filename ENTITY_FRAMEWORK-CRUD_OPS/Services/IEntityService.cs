using ENTITY_FRAMEWORK_CRUD_OPS.Data;
using ENTITY_FRAMEWORK_CRUD_OPS.Model;
using Microsoft.EntityFrameworkCore;

namespace ENTITY_FRAMEWORK_CRUD_OPS.Services
{
    public interface IEntityService
    {
        public List<Entity> GetAll();
        public Entity GetById(int id);
        public void AddEntity(Entity entity);
        public void DeleteEntity(int id);
        public void UpdateEntity(Entity record);
    }
}
