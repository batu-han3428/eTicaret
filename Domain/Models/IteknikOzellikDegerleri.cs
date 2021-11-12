using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface IteknikOzellikDegerleri
    {
        int id { get; set; }
        List<TeknikOzellikler> TeknikOzellikler { get; set; }
        string teknikOzellikDegeri { get; set; }
    }
}
