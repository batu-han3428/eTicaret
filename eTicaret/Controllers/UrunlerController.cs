using BL.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicaret.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UrunlerController : Controller
    {
        private readonly UrunlerServices _urunler;
        public UrunlerController(UrunlerServices urunler)
        {
            _urunler = urunler;
        }


        public IActionResult Index(object location)
        {
            var result = _urunler.hepsiniListele(null);

            if (result.Count > 0) {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }       
        }
    }
}
