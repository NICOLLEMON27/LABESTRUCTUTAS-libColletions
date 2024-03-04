using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLineal<T> : iADTLineal<T> where T : IComparable<T>
    {
        int length;
        public bool opModify(int idx, T item)
        {
            throw new NotImplementedException();
        }
        public bool opRetrieve(int idx, T item)
        {
            throw new NotImplementedException();
        }
        public int opFind(T item)
        {
            throw new NotImplementedException();
        }
        public bool opExist(T item)
        {
            throw new NotImplementedException();
        }
        public int opGetLength()
        {
            throw new NotImplementedException();
        }
        public T[] opToArray()
        {
            throw new NotImplementedException();
        }
        public string opToString()
        {
            throw new NotImplementedException();
        }
        public bool opToItems(T array)
        {
            throw new NotImplementedException();
        }

    }
}
