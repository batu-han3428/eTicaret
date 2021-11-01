using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface ISoftDelete
    {
        bool isDeleted { get; set; }
        DateTime DeletedTime { get; set; }
    }
}
