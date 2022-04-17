using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PixelProje.Ent;
using PixelProje.Repos;
using PixelProje.Uow;

namespace PixelProje.Services.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AboneIslemController : ControllerBase
    {
        IUnitOfWork _unitOFWork;
        public AboneIslemController(IUnitOfWork unitOfWork)
        {
            _unitOFWork = unitOfWork;
        }

        //Abone Listeleri
        [HttpGet(Name = "AboneList")]
        public IEnumerable<Abone> List()
        {
            return _unitOFWork._aboneRepository.List();
        }
        //Fatura ödeme işlemi
        [HttpPut(Name = "PaymentInvoicee")]
        public IActionResult PaymentInvoicee(int id, [FromBody] Payment py)
        {
            Invoice find = _unitOFWork._invoiceRepository.Find(id);
            find.Abone.Balance = find.Abone.Balance - py.InvoiceAmount;

            find.Abone.AboneSituation = py.AboneSituation;
            _unitOFWork._invoiceRepository.Update(find);
            _unitOFWork.Save();
            return RedirectToAction("Payment");
        }
    }
}
