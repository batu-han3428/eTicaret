using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Concrete
{
    public class TeknikOzellikler:ITeknikOzellikler
    {
        public int id { get; set; }
        public List<urunlerTeknikOzellikler> urunlerTeknikOzellikler { get; set; }     
        public string teknikOzellikBaslik { get; set; }
        public teknikOzellikDegerleri teknikOzellikDegerleri { get; set; }
    }
}
