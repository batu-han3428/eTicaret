using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class TeknikOzelliklerAnaBaslik:ITeknikOzelliklerAnaBaslik
    {
        [Key]
        public int Id { get; set; }
        public string anaBaslik { get; set; }
        public List<TeknikOzellikler> TeknikOzellikler { get; set; }
        public List<urunlerTeknikOzellikler> urunlerTeknikOzellikler { get; set; }
    }
}
