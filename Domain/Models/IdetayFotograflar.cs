using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface IdetayFotograflar
    {
        int id { get; set; }
        string detayFotograf { get; set; }
        Urunler urunler { get; set; }

    }
}
