using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface IkategorilerAltKategoriler
    {
        int kategorilerId { get; set; }
        Kategoriler Kategoriler { get; set; }
        int AltKategorilerId { get; set; }
        AltKategoriler AltKategoriler { get; set; }
    }
}
