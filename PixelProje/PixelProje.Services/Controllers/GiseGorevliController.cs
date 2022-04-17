using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PixelProje.Ent;
using PixelProje.Repos;
using PixelProje.Uow;

namespace PixelProje.Services.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class GiseGorevliController : ControllerBase
    {
        IUnitOfWork _unitOFWork;
        public GiseGorevliController(IUnitOfWork unitOfWork)
        {
            _unitOFWork = unitOfWork;
        }

        //Yeni Abone olusturma
        [HttpPost(Name = "Create")]
        public IActionResult Create([FromBody] AboneCreate ab)
        {
            _unitOFWork._aboneRepository.Create(new Abone
            {
                Name = ab.Name,
                LastName = ab.LastName,
                Adress = ab.Adress,
                Tel = ab.Tel,
                AboneSituation = ab.AboneSituation,
                Balance = ab.Balance,
                Deposit = 1000
            });
            _unitOFWork.Save();
            return Ok(ab.Name);
        }

        //Abone Sorgulama
        [HttpPost(Name = "Find")]
        public Abone Find([FromBody] int id)
        {
            var abone = _unitOFWork._aboneRepository.Find(id);
            return abone;
        }

        //Fatura ödeme işlemi
        [HttpPut(Name = "PaymentInvoice")]
        public IActionResult PaymentInvoice(int id, [FromBody] Payment py)
        {
            Invoice find = _unitOFWork._invoiceRepository.Find(id);
            find.Abone.Balance = find.Abone.Balance - py.InvoiceAmount;

            find.Abone.AboneSituation = py.AboneSituation;
            _unitOFWork._invoiceRepository.Update(find);
            _unitOFWork.Save();
            return RedirectToAction("Payment");
        }
        //Abonelik kapatma - Eksik var tam değil
        //[HttpDelete]
        //[Route("{id:int}")]
        //public IActionResult AboneDelete(int id,[FromBody] Payment py)
        //{
        //    Abone dlt = _unitOFWork._aboneRepository.Find(id);
        //    if (dlt.InvoiceAmount == true)
        //    {
        //        _unitOFWork._aboneRepository.Delete(id);
        //        _unitOFWork.Save();
        //        return Ok(dlt);
        //    }
        //    return NotFound();
        //}

       
    }
}
