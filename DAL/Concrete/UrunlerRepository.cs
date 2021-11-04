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
    }
}