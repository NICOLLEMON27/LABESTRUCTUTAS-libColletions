using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iList<T> where T : IComparable<T>
    {
        bool opAdd(T item);
        bool opInsert(int index, T item);
        bool opRemove(int idx, T item);
    }
}
