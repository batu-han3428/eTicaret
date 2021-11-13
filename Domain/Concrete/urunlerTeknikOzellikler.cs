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
        public int teknikOzelliklerAnaBaslikId { get; set; }
        public TeknikOzelliklerAnaBaslik TeknikOzelliklerAnaBaslik { get; set; }
    }
}
