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
        public TeknikOzelliklerAnaBaslik TeknikOzelliklerAnaBaslik { get; set; }
        public string TeknikOzelliklerAltBaslik { get; set; }
        public string teknikOzellikDegerleri { get; set; }
    }
}
