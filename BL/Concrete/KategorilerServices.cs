using BL.Models;
using DAL.Models;
using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class KategorilerServices:IKategorilerServices
    {
        private IKategorilerRepository _KategorilerRepository;

        public KategorilerServices(IKategorilerRepository KategorilerRepository)
        {
            _KategorilerRepository = KategorilerRepository;
        }

        public Kategoriler AltKategorileriGetir(string location)
        {
            return _KategorilerRepository.AltKategorileriGetir(location);
        }
    }
}
