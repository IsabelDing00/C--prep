using System;


namespace Assign04
{
    public class GenericRepository : IRepository<Entity>
    {
        List<Entity> list = new List<Entity>();
        public void Add(Entity item)
        {
            list.Add(item);
        }

        public IEnumerable<Entity> GetAll()
        {
            return list;
        }

        public Entity GetById(int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    return list[i];
                }
            }
            return null;
        }

        public void Remove(Entity item)
        {
            list.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
