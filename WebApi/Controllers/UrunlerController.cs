using BL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult UrunGetir(string location)
        {
            var urunler = UrunlerServices.urunleriGetir(location);

            if (urunler.Count > 0)
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
