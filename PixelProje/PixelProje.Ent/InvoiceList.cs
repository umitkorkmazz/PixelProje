using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Ent
{
    public class InvoiceList
    {
        public int InvoiceId { get; set; }
        public string? InvoiceName { get; set; }
        public string? InvoiceSurname { get; set; }
        public int InvoiceTel { get; set; }
        public string? InvoiceAdress { get; set; }
        public int InvoiceAmount { get; set; }

        //--------------
        public bool AboneSituation { get; set; }
    }
}
