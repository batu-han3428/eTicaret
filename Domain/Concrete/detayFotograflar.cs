using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class detayFotograflar : IdetayFotograflar
    {
        public int id { get; set; }
        public string detayFotograf { get; set; }
        public Urunler urunler { get; set; }
    }
}
