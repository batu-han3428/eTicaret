using BL.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController] 
    public class UrunlerController : Controller
    {
        private readonly UrunlerServices _UrunlerServices;

        public UrunlerController(UrunlerServices UrunlerServices)
        {
            _UrunlerServices = UrunlerServices;
        }

        public IActionResult Index(object location)
        {

            return View();
        }
    }
}
