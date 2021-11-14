using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class urunlerAltKategoriler : IurunlerAltKategoriler
    {
        public int urunlerId { get; set; }
        public Urunler Urunler { get; set; }
        public int AltKategorilerId { get; set; }
        public AltKategoriler AltKategoriler { get; set; }
    }
}
