using pkgServices.pkgCollletions.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollletions.pkgLineal.pkgVector
{
    public class clsVevtorStack<T> : iStack<T> where T : IComparable<T>
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
