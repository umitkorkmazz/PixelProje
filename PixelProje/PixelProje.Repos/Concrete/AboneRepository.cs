using PixelProje.Core;
using PixelProje.Dal;
using PixelProje.Ent;
using PixelProje.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Repos.Concrete
{
    public class AboneRepository : BaseRepository<Abone>, IAboneRepository
    {
        public AboneRepository(Context db) : base(db)
        {
        }

        public List<AboneList> GetAboneLists()
        {
            throw new NotImplementedException();
        }

        //public List<AboneList> GetAboneLists()
        //{
        //    return Set().Select(x => new AboneList
        //    {
        //        AboneId = x.AboneId,
        //        Name = x.Name,
        //        LastName = x.LastName,
        //        Adress = x.Adress,
        //        Deposit = x.Deposit,
        //        Tel = x.Tel
        //    }).ToList();
        //}

    }
}
