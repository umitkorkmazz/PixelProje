using PixelProje.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Uow
{
    public interface IUnitOfWork
    {
        IAboneRepository _aboneRepository { get; }
        IInvoiceRepository _invoiceRepository { get; }
        void Save();
    }
}
