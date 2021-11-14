using BL.Models;
using DAL.Models;
using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class UrunlerServices : IUrunlerServices
    {
        private IUrunlerRepository _UrunlerRepository;

        public UrunlerServices(IUrunlerRepository _UrunlerRepository)
        {
            this._UrunlerRepository = _UrunlerRepository;
        }

        public List<Urunler> urunleriGetir(string location)
        {
            return _UrunlerRepository.urunleriGetir(location);
        }

        public IEnumerable<Urunler> urunleriGetirSayfali(string location, Pagination ownerParameters)
        {
            return _UrunlerRepository.urunleriGetirSayfali(location, ownerParameters);
        }

        public int toplamUrunSayisi(string location, Pagination pagination)
        {
            return _UrunlerRepository.toplamUrunSayisi(location, pagination);
        }

        public Urunler urunGetir(int id)
        {
            return _UrunlerRepository.urunDetayGetir(id);
        }


    }
}
