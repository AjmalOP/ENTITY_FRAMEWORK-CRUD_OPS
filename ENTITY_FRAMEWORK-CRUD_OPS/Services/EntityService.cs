using ENTITY_FRAMEWORK_CRUD_OPS.Data;
using ENTITY_FRAMEWORK_CRUD_OPS.Model;

namespace ENTITY_FRAMEWORK_CRUD_OPS.Services
{
    public class EntityService : IEntityService
    {
        public readonly EntityDb _entityDb;
        public EntityService(EntityDb entityDb)
        {
            _entityDb = entityDb;
        }
        public List<Entity> GetAll()
        {
            var Table = _entityDb.entities.ToList();
            if (Table.Count > 0)
            {
                return Table;
            }
            return new List<Entity>();
        }

        public Entity GetById(int id)
        {
            var Entity = _entityDb.entities.FirstOrDefault(e => e.Id == id);
            if (Entity == null)
            {
                return new Entity();
            }
            return Entity;
        }
        public void AddEntity(Entity entity)
        {
            _entityDb.entities.Add(entity);
            _entityDb.SaveChanges();
        }
        public void DeleteEntity(int id)
        {
            var entity = _entityDb.entities.FirstOrDefault(data => data.Id == id);
            _entityDb.entities.Remove(entity);
            _entityDb.SaveChanges();
        }
        public void UpdateEntity(Entity record)
        {
            var entity = _entityDb.entities.FirstOrDefault(data => data.Id == record.Id);
            entity.FName = record.FName;
            entity.LName = record.LName;
            entity.Age = record.Age;
            _entityDb.SaveChanges();
        }
    }
}
