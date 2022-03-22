using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.BE
{
    public interface IPeriodicElement
    {
        PeriodicElement Get(int id);
        PeriodicElement Get(string name);
        List<PeriodicElement> GetAll();
        bool Create(PeriodicElement periodicElement);
        bool Update(PeriodicElement periodicElement);
        bool Delete(int id);
        bool Delete(string name);
    }
}
