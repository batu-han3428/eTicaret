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
        TeknikOzelliklerAnaBaslik TeknikOzelliklerAnaBaslik { get; set; }
        string TeknikOzelliklerAltBaslik { get; set; }
        string teknikOzellikDegerleri { get; set; }
       
    }
}
