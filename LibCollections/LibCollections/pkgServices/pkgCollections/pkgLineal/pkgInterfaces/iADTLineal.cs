using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iADTLineal<T> where T : IComparable<T>
    {
        bool opModify(int idx, T item);
        bool opRetrieve(int idx, T item);
        int opFind(T item);
        bool opExist(T item);
        int opGetLength();
        T[] opToArray();
        string opToString();
        bool opToItems(T array);

    }
}
