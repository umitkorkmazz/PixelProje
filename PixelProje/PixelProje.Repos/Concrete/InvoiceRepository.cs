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
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(Context db) : base(db)
        {
        }

        public List<InvoiceList> GetInvoiceLists()
        {
            throw new NotImplementedException();
        }
        //public List<InvoiceList> GetInvoiceLists()
        //{
        //    return Set().Select(x => new InvoiceList
        //    {
        //        InvoiceId = x.InvoiceId,
        //        InvoiceName = x.InvoiceName,
        //        InvoiceSurname = x.InvoiceSurname,
        //        InvoiceTel = x.InvoiceTel,
        //        InvoiceAdress = x.InvoiceAdress,
        //        InvoiceAmount = x.InvoiceAmount
        //    }).ToList();
        //}
    }
}
