using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IBaseRepository<T>
       where T : class, new()
    {
        int ekle(T model);
        int sil(T model);
        int guncelle(T model); 
        T listele(int id);
        List<T> hepsiniListele(Expression<Func<T, bool>> filter = null);
        
    }
}
