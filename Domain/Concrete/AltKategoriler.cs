using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class AltKategoriler:IAltKategoriler
    {
        public int id { get; set; }
        public string altKategoriAdi { get; set; }
        public List<kategorilerAltKategoriler> kategorilerAltKategoriler { get; set; }
        public List<urunlerAltKategoriler> urunlerAltKategoriler { get; set; }
    }
}
