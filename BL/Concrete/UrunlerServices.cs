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

        public List<Urunler> hepsiniListele(Expression<Func<Urunler, bool>> filter = null)
        {
            return _UrunlerRepository.hepsiniListele(filter);
        }

        public List<Urunler> urunleriGetir(string location)
        {
            return _UrunlerRepository.urunleriGetir(location);
        }

    }
}
