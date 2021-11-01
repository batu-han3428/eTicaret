using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface IKategoriler:IAuditEntity, ISoftDelete
    {
        int Id { get; set; }

        string Ad { get; set; }

        string Aciklama { get; set; }

        List<Urunler> urunAdi { get; set; }
    }
}
