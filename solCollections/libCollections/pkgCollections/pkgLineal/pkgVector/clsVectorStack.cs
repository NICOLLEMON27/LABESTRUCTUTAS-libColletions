using System;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;

namespace pkgServices.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorStack<T> : iStack<T> where T : IComparable<T>
    {
        public bool opPeek(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPop(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
        

    }
}
