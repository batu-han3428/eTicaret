using DAL.Models;
using Domain.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class UrunlerRepository : BaseRepository<Urunler>, IUrunlerRepository
    {
        public List<Urunler> urunleriGetir(string location)
        {           
            return context.Urunler.Where(x => x.Kategori.Ad == location).ToList();
        }

         public IEnumerable<Urunler> urunleriGetirSayfali(string location, Pagination pagination)
         {
            return urunleriGetir(location)
                .OrderBy(on => on.Id)
                .Skip((pagination.PageNumber - 1) * 20)
                .Take(20)
                .ToList();
         }

         public int toplamUrunSayisi(string location)
         {
            return urunleriGetir(location).Count;
         }

        public Urunler urunDetayGetir(int id)
        {
            var urun = context.Urunler.Include(x => x.detayFotograflar).FirstOrDefault(x => x.Id == id);

            return urun;
               
        }
    }
}