using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface IAltKategoriler
    {
        int id { get; set; }
        string altKategoriAdi { get; set; }
        List<kategorilerAltKategoriler> kategorilerAltKategoriler { get; set; }
        List<urunlerAltKategoriler> urunlerAltKategoriler { get; set; }
    }
}
