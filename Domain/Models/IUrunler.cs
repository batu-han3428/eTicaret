using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface IUrunler : IAuditEntity, ISoftDelete
    {
        int Id { get; set; }
        string Ad { get; set; }
        float Fiyat { get; set; }
        float IndirimliFiyat { get; set; }
        int IndirimYuzde { get; set; }
        string UrunAciklamaBaslik { get; set; }
        string UrunEkAciklama { get; set; }
        string UrunAciklamaIcerik { get; set; }
        int Stok { get; set; }
        string Marka { get; set; }
        string DigerKategorileri { get; set; }
        Kategoriler Kategori { get; set; }
        List<urunlerTeknikOzellikler> urunlerTeknikOzellikler { get; set; }
        string Fotograf { get; set; }
        string MarkaFotograf { get; set; }
        //string detayFotogaflar { get; set; }
        List<detayFotograflar> detayFotograflar { get; set; }
    }
}
