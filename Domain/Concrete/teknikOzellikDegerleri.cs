using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class teknikOzellikDegerleri: IteknikOzellikDegerleri
    {
        public int id { get; set; }
        public List<TeknikOzellikler> TeknikOzellikler { get; set; }
        public string teknikOzellikDegeri { get; set; }
    }
}
