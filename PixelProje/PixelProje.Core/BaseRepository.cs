using Microsoft.EntityFrameworkCore;
using PixelProje.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Core
{
    public class BaseRepository<T>:IBaseRepository<T>where T : class
    {
        Context _db;
        public BaseRepository(Context db)
        {
            _db = db;
        }
        public bool Create(T ent)
        {

            return Set().Add(ent) != null;
        }
        public bool Update(T ent)
        {
            return Set().Add(ent) != null;
        }
        public bool Delete(int id)
        {
            return Set().Remove(Find(id)) != null;
        }
        public T Find(int id)
        {
            return Set().Find(id);
        }
        public List<T> List()
        {
            return Set().ToList();
        }
        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }
    }
}
