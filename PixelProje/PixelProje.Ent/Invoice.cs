using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelProje.Ent
{
    public class Invoice
    {
      
        [Key]
        public int InvoiceId { get; set; }
        public string ?InvoiceName { get; set; }
        public string ?InvoiceSurname { get; set; }
        public int InvoiceTel { get; set; }
        public string ?InvoiceAdress { get; set; }
        public  int InvoiceAmount  { get; set; }           
        public int AboneId { get; set; }
        [ForeignKey("AboneId")]
        public Abone ?Abone { get; set; }
        public Invoice ?Invoices { get; set; }
       
    }
}
