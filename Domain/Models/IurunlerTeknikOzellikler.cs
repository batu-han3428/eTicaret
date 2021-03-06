using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Models
{
    public interface IurunlerTeknikOzellikler 
    {
        int urunlerId { get; set; }
        Urunler urunler { get; set; }
        int teknikOzelliklerAnaBaslikId { get; set; }
        TeknikOzelliklerAnaBaslik TeknikOzelliklerAnaBaslik { get; set; }
    }
}
