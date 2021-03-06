using PixelProje.Core;
using PixelProje.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Repos.Abstract
{
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
        List<InvoiceList> GetInvoiceLists();
    }
}
