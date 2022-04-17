using PixelProje.Dal;
using PixelProje.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        Context _db;
        public IAboneRepository _aboneRepository { get; private set; }

        public IInvoiceRepository _invoiceRepository { get; private set; }
        public UnitOfWork(Context db,IAboneRepository aboneRepository,IInvoiceRepository ınvoiceRepository)
        {
            _db = db;
            _aboneRepository = aboneRepository;
            _invoiceRepository = ınvoiceRepository;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
