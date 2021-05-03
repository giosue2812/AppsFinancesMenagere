using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Interfaces
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; } 
    }
}
