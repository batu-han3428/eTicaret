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
    public class KategorilerRepository : BaseRepository<Kategoriler>, IKategorilerRepository
    {
        public Kategoriler AltKategorileriGetir(string location)
        {
           
            return context.Kategoriler.Where(x => x.Ad == location).Include(x=>x.kategorilerAltKategoriler).ThenInclude(x=>x.AltKategoriler).AsNoTracking().FirstOrDefault();
        }
    }
}
