using BL.Models;
using Domain.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class UrunlerController : ControllerBase
    {
        private readonly IUrunlerServices UrunlerServices;
        private readonly IKategorilerServices _KategorilerServices;

        public UrunlerController(IUrunlerServices UrunlerServices, IKategorilerServices KategorilerServices)
        {
            this.UrunlerServices = UrunlerServices;
            _KategorilerServices = KategorilerServices;
        }

  
        [HttpGet("UrunGetir/{location}")]
        public IActionResult UrunGetir(string location, [FromQuery] Pagination pagination)
        {
            UrunlerViewModel urunler = new UrunlerViewModel();

            urunler.Urunler = UrunlerServices.urunleriGetirSayfali(location, pagination);
            urunler.toplamUrunSayisi = UrunlerServices.toplamUrunSayisi(location, pagination);

            if (urunler.toplamUrunSayisi > 0)
            {
                return Ok(urunler);
            }
            else
            {
                return BadRequest();
            }  
        }
    
        [HttpGet("UrunDetayGetir/{id}")]
        public IActionResult UrunDetayGetir(int id)
        {
            var urun = UrunlerServices.urunGetir(id);

            if (urun != null)
            {
                return Ok(urun);
            }
            else
            {
                return BadRequest();
            }
        }
        
        [HttpGet("AltKategorileriGetir/{location}")]
        public IActionResult AltKategorileriGetir(string location)
        {
            var veri = _KategorilerServices.AltKategorileriGetir(location);

            if (veri != null)
            {
                return Ok(veri);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
