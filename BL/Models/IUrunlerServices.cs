using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public interface IUrunlerServices
    {
        List<Urunler> hepsiniListele(Expression<Func<Urunler, bool>> filter = null);
    }
}
