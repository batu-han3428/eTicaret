using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class kategorilerAltKategoriler : IkategorilerAltKategoriler
    {
        public int kategorilerId { get; set; }
        public Kategoriler Kategoriler { get; set; }
        public int AltKategorilerId { get; set; }
        public AltKategoriler AltKategoriler { get; set; }
    }
}
