using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface ITeknikOzelliklerAnaBaslik
    {
        int Id { get; set; }
        string anaBaslik { get; set; }
        List<TeknikOzellikler> TeknikOzellikler { get; set; }
        List<urunlerTeknikOzellikler> urunlerTeknikOzellikler { get; set; }
    }
}
