using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IUrunlerRepository : IBaseRepository<Urunler>
    {
        List<Urunler> urunleriGetir(string location);
        IEnumerable<Urunler> urunleriGetirSayfali(string location, Pagination pagination);

        int toplamUrunSayisi(string location, Pagination pagination);

        Urunler urunDetayGetir(int id);

    }
}
