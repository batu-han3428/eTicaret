using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Kategoriler:IKategoriler
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Aciklama { get; set; }
        public List<Urunler> urunAdi { get; set; }
        public DateTime createTime { get; set; }
        public DateTime updateTime { get; set; }
        public bool isDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
    }
}
