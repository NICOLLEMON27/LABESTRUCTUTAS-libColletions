using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iQueue<T> where T : IComparable<T>
    {
        bool opPush(T prmItem);
        bool opPop(ref T prmItem);
        bool opPeek(ref T prmItem);
    }
}
