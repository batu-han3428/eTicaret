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

        public UrunlerController(IUrunlerServices UrunlerServices)
        {
            this.UrunlerServices = UrunlerServices;
        }

  
        [HttpGet("UrunGetir/{location}")]
        public IActionResult UrunGetir(string location, [FromQuery] Pagination pagination)
        {
            UrunlerViewModel urunler = new UrunlerViewModel();

            urunler.Urunler = UrunlerServices.urunleriGetirSayfali(location, pagination);
            urunler.toplamUrunSayisi = UrunlerServices.toplamUrunSayisi(location);

            if (urunler.toplamUrunSayisi > 0)
            {
                return Ok(urunler);
            }
            else
            {
                return BadRequest();
            }  
        }
    }
}
