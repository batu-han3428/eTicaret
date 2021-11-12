using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Urunler:IUrunler
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public float Fiyat { get; set; }
        public float IndirimliFiyat { get; set; }
        public int IndirimYuzde { get; set; }
        public string UrunAciklamaBaslik { get; set; }
        public string UrunEkAciklama { get; set; }
        public string UrunAciklamaIcerik { get; set; }
        public int Stok { get; set; }
        public string Marka { get; set; }
        public string DigerKategorileri { get; set; }
        public Kategoriler Kategori { get; set; }
        public List<urunlerTeknikOzellikler> urunlerTeknikOzellikler { get; set; }
        public DateTime createTime { get; set; }
        public DateTime updateTime { get; set; }
        public bool isDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
        public string Fotograf { get; set; }
        public string MarkaFotograf { get; set; }

        //public string detayFotogaflar { get; set; }
        public List<detayFotograflar> detayFotograflar { get; set; }
    }
}
