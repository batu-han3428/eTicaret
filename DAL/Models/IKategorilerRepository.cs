using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IKategorilerRepository : IBaseRepository<Kategoriler>
    {
        Kategoriler AltKategorileriGetir(string location);
    }
}
