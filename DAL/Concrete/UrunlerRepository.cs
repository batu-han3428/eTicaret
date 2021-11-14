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
            if (pagination.Siralama == "enpopuler")
            {
                return urunleriGetir(location)
                  .OrderBy(x => x.Id)
                  .Skip((pagination.PageNumber - 1) * 20)
                  .Take(20)
                  .ToList();
            }
            else if (pagination.Siralama == "a-z")
            {
                return urunleriGetir(location)
                 .OrderBy(x => x.Ad)
                 .Skip((pagination.PageNumber - 1) * 20)
                 .Take(20)
                 .ToList();
            }
            else if (pagination.Siralama == "z-a")
            {
                return urunleriGetir(location)
                 .OrderByDescending(x => x.Ad)
                 .Skip((pagination.PageNumber - 1) * 20)
                 .Take(20)
                 .ToList();
            }
            else if (pagination.Siralama == "artanfiyat")
            {
                return urunleriGetir(location)
                 .OrderByDescending(x => x.IndirimliFiyat > 0 ? x.IndirimliFiyat : x.Fiyat).Reverse()
                 .Skip((pagination.PageNumber - 1) * 20)
                 .Take(20)
                 .ToList();
            }
            else if (pagination.Siralama == "azalanfiyat")
            {
                return urunleriGetir(location)
                .OrderByDescending(x => x.IndirimliFiyat>0?x.IndirimliFiyat:x.Fiyat)
                .Skip((pagination.PageNumber - 1) * 20)
                .Take(20)
                .ToList();
            }
            else if (pagination.Siralama == "indirimliurunler")
            {
                return urunleriGetir(location)
                 .Where(x=>x.IndirimliFiyat>0)
                 .OrderByDescending(x => x.IndirimYuzde)
                 .Skip((pagination.PageNumber - 1) * 20)
                 .Take(20)
                 .ToList();
            }
            else
            {
                return urunleriGetir(location)
                .OrderBy(x=>x.Id)
                .Skip((pagination.PageNumber - 1) * 20)
                .Take(20)
                .ToList();
            }
           
        }

        public int toplamUrunSayisi(string location, Pagination pagination)
        {
            
           if (pagination.Siralama == "indirimliurunler")
           {

                return context.Urunler.Where(x => x.Kategori.Ad == location && x.IndirimYuzde > 0).ToList().Count;              
           }
           else
           {
                return urunleriGetir(location).Count;
           } 
        }
            
        public Urunler urunDetayGetir(int id)
        {

            var urun = context.Urunler.Include(x => x.detayFotograflar).Include(x => x.urunlerTeknikOzellikler).ThenInclude(x => x.TeknikOzelliklerAnaBaslik).ThenInclude(x => x.TeknikOzellikler).FirstOrDefault(x => x.Id == id);

            return urun;
               
        }

    }
}