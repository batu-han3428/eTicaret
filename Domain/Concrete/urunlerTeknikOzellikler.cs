using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class urunlerTeknikOzellikler : IurunlerTeknikOzellikler
    {
        public int urunlerId { get; set; }
        public Urunler urunler { get; set; }
        public int teknikOzelliklerId { get; set; }
        public TeknikOzellikler teknikOzellikler { get; set; }
    }
}
