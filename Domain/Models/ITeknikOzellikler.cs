using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface ITeknikOzellikler
    {
        int id { get; set; }
        List<urunlerTeknikOzellikler> urunlerTeknikOzellikler { get; set; }
        string teknikOzellikBaslik { get; set; }
        teknikOzellikDegerleri teknikOzellikDegerleri { get; set; }
    }
}
